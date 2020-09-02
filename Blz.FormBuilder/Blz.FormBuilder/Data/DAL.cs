using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using Blz.FormBuilder.Context;
using Blz.FormBuilder.Services;
using Newtonsoft.Json;
using Blazored.SessionStorage;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;

namespace Blz.FormBuilder.Data
{
    public class DAL
    {
        readonly int activationCodeLength = 20;
        readonly string verifyLinkUrl = "https://localhost:44375/verification/activation_code/";
        readonly UserContext _context = new UserContext();
        [Inject]
        HttpContextAccessor ContextAccessor { get; set; }
        public string CreateEmailActivationCode(int length) 
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor((122 - 47) * flt)) + 48;
                if (shift > 57 && shift < 65) shift = 67;
                if (shift > 90 && shift < 97) shift = 76;
                letter = Convert.ToChar(shift);
                str_build.Append(letter);
            }
            return DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss") + str_build.ToString();
        }
        public async Task<User> CreateUser([FromBody] User user)
        {
            User result = await _context.Users.FirstOrDefaultAsync(record => record.UserEmail == user.UserEmail);
            if(result == null)
            {
                string activation_code = CreateEmailActivationCode(activationCodeLength);
                user.EmailLinkVerificationCode = verifyLinkUrl + activation_code;
                user.EmailLinkVerificationCodeValidUntil = DateTime.UtcNow.AddDays(1);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                VarData.USER_ADDEDTO_TABLE = true;
                return user;
            }else
            {
                VarData.USER_ADDEDTO_TABLE = false;
                return user;
            }
        }
        public async Task<User> LoginUser([FromBody] User user)
        {
            Console.WriteLine(user.UserSaltPassword);
            User result = await _context.Users.FirstOrDefaultAsync(record => record.UserEmail == user.UserEmail);
            Console.WriteLine("ddd");
            // Section::Account SignIn Process
            if (!result.IsUserLoggedOnAtLeastOnce)
            {
                if (result.UserSaltPassword.Contains(user.UserSaltPassword))
                {
                        
                    if (result.IsEmailAddressBeenVerifiedByUser)
                    {
                            
                        result.IsUserLoggedOnAtLeastOnce = true;
                        Console.WriteLine("ddd");
                        //_context.Entry(result).State = EntityState.Modified;
                        VarData.GOTO_URL = "/home";
                    }
                    else
                    {
                        // Go to start of Section::Send Reverification Email To User To Confirm Account
                        Console.WriteLine("Go to start of section::send reverification email to user to confirm account");
                        VarData.GOTO_URL = "/email/reverification";
                    }
                }
                if (!result.UserSaltPassword.Contains(user.UserSaltPassword))
                {
                    Console.WriteLine("Login failed");
                    // We will store a record in ‘LoginsAudit’
                    SaveLoginAudit(1, true, false, 1, "");
                    // Display ErrorAnalysis to the user, and allow them to try again.
                    VarData.GOTO_URL = "/login/fail";
                }
            }
            if (result.IsUserLoggedOnAtLeastOnce)
            {
                if (result.IsEmailAddressBeenVerifiedByUser)
                {
                    if (result.UserSaltPassword.Contains(user.UserSaltPassword))
                    {
                        // User Login Success
                        // We will store a record in 'LoginsAudit'
                        SaveLoginAudit(1, true, false, 1, "");
                        // Navigate to the homepage
                        VarData.GOTO_URL = "/home";
                    }
                    if (!result.UserSaltPassword.Contains(user.UserSaltPassword))
                    {
                        SaveLoginAudit(1, false, true, 1, "");
                        //Display ErrorAnalysis and go to login
                        VarData.GOTO_URL = "/login/fail";
                    }
                }
                if (!result.IsEmailAddressBeenVerifiedByUser)
                {
                    // SECTION::Send Reverification Email To User To Confirm Account
                    VarData.GOTO_URL = "/email/reverification";
                }
            }
            return result;
        }
        public async Task<User> ResendEmail(User user)
        {
            var result = await _context.Users.FirstOrDefaultAsync(record => record.UserEmail == user.UserEmail) as User;

            int num_var = result.UserSaltPassword.IndexOf(result.UserSalt);
            string userpassword = result.UserSaltPassword.Substring(0, num_var);

            // Create new salt
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            result.UserSalt = Convert.ToBase64String(salt);
            result.UserSaltPassword = userpassword + result.UserSalt;

            string activation_code = CreateEmailActivationCode(activationCodeLength);
            result.EmailLinkVerificationCode = verifyLinkUrl + activation_code;

            // Update user data in table
            result.EmailLinkVerificationCodeValidUntil = DateTime.UtcNow.AddDays(1);
            _context.Entry(result).State = EntityState.Modified;

            // Save data to VerificationEmail Table
            SaveVerificationEmail(result.UserIpAddress, result.UserId, result.EmailLinkVerificationCode, result.EmailLinkVerificationCodeValidUntil, true, result.UserSalt);
            return result;
        }
        public async Task<User> CheckActivationCode(string code)
        {
            User result = await _context.Users.FirstOrDefaultAsync(record => record.EmailLinkVerificationCode == code);
            DateTime validDT = DateTime.UtcNow;
            Console.WriteLine("code=" + code);
            Console.WriteLine("result=" + result.EmailLinkVerificationCode);
            if (result != null)
            {
                if (DateTime.Compare(validDT, result.EmailLinkVerificationCodeValidUntil) == -1)
                {
                    Console.WriteLine("Your email verificated now");
                    result.IsEmailAddressBeenVerifiedByUser = true;
                    result.IsRegisterationConfirmationEmailSent = true;
                    result.IsSuccessfulVerification = true;
                    result.IsSuccess = true;
                    result.LinkUrlAttemped = code;
                    result.LoginTypeId = 1;
                    result.IsUserLoggedOnAtLeastOnce = true;
                    result.IsError = false;
                    result.ErrorAnalysis = "";
                    result.ErrorDescription = "";
                    _context.Entry(result).State = EntityState.Modified;

                    // Save data to AccountVerification Table
                    SaveAccountVerification(result.UserId, result.UserId, true, result.EmailLinkVerificationCode, null);
                    VarData.VERIFICATOIN_SUCCESS = true;
                }
                if (DateTime.Compare(validDT, result.EmailLinkVerificationCodeValidUntil) == 0)
                {
                    Console.WriteLine("Your email verification time out, please resend email for verification now.");
                    result.IsEmailAddressBeenVerifiedByUser = false;
                    _context.Entry(result).State = EntityState.Modified;

                    // Save data to AccountVerification Table
                    SaveAccountVerification(-1, -1, false, result.EmailLinkVerificationCode, "");
                    VarData.VERIFICATOIN_SUCCESS = false;
                }
            }
            else
            {
                //Display message to the user indicating that the email verification link was invalid
                SaveAccountVerification(result.UserId, result.UserId, false, result.EmailLinkVerificationCode, "No record was found");
                VarData.VERIFICATOIN_SUCCESS = false;
            }
            return result;
        }
        public async void SaveLoginAudit(int loginTypeId, bool isSuccess, bool isError, int errorAnalysis, string exceptioin)
        {
            LoginAudit loginAudit = new LoginAudit();
            loginAudit.LADateTime = DateTime.UtcNow;
            ContextAccessor = new HttpContextAccessor();
            loginAudit.LAIpAddress = ContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            loginAudit.LALoginTypeId = loginTypeId;
            loginAudit.LAIsSuccess = isSuccess;
            loginAudit.LAIsError = isError;
            loginAudit.LAErrorAnalysis = errorAnalysis;
            loginAudit.LAException = exceptioin;
            _context.LoginAudits.Add(loginAudit);
            await _context.SaveChangesAsync();
        }
        public async void SaveVerificationEmail(string ipAddress, int userId, string emailLinkVerificationCode, DateTime emailLinkVerificationCodeValidUntil, bool isNewPasswordCreated, string userSalt)
        {
            // Save data to VerificationEmail Table
            VerificationEmail verificationEmail = new VerificationEmail();
            verificationEmail.VETime = DateTime.UtcNow;
            verificationEmail.VEIpAddress = ipAddress;
            verificationEmail.VEUserId = userId;
            verificationEmail.VEEmailLinkVerificationCode = emailLinkVerificationCode;
            verificationEmail.VEEmailLinkVerificationCodeValidUntil = emailLinkVerificationCodeValidUntil;
            verificationEmail.IsNewPasswordCreated = isNewPasswordCreated;
            verificationEmail.NewPasswordCreatedSALT = userSalt;
            _context.VerificationEmails.Add(verificationEmail);
            await _context.SaveChangesAsync();
        }
        public async void SaveAccountVerification(int userId, int verifiedAgainstEmailVerificationRecordId, bool isSuccessfulVerification, string linkUrlAttempted, string errorDescription)
        {
            // Save data to AccountVerification Table
            AccountVerification accountVerification = new AccountVerification();
            accountVerification.AVTime = DateTime.UtcNow;
            ContextAccessor = new HttpContextAccessor();
            accountVerification.AVIpAddress = ContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            accountVerification.AVUserId = userId;
            accountVerification.AVVerifiedAgainstEmailVerificationRecordId = verifiedAgainstEmailVerificationRecordId;
            accountVerification.AVIsSuccessfulVerification = isSuccessfulVerification;
            accountVerification.AVLinkUrlAttempted = linkUrlAttempted;
            accountVerification.AVErrorDescription = errorDescription;
            _context.AccountVerifications.Add(accountVerification);
            await _context.SaveChangesAsync();
        }
    }
}

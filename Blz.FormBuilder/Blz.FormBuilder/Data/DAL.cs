using Blz.FormBuilder.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

namespace Blz.FormBuilder.Data
{
    public class DAL
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        HttpContextAccessor contextAccessor { get; set; }
        UserContext _context = new UserContext();
        public async Task CreateUser([FromBody] User user)
        {
            try
            {
                Console.WriteLine("Register Controller");
                Console.WriteLine(user.UserName);
                _context.Users.Add(user);
                var result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task SignUser([FromBody] User user)
        {
            try
            {
                Console.WriteLine("user login");
                var result = await _context.Users.FirstOrDefaultAsync(record => record.UserEmail == user.UserEmail) as User;
                Console.WriteLine(result.IsUserLoggedOnAtLeastOnce);
                Console.WriteLine(user.UserSalt);
                Console.WriteLine(result.UserSalt);
                Console.WriteLine(user.IsEmailAddressBeenVerifiedByUser);
                if(result != null)
                {
                    // Section::Account SignIn Process
                    if(!result.IsUserLoggedOnAtLeastOnce)
                    {
                        if(user.UserSalt != "" && user.UserSalt == result.UserSalt)
                        {
                            if(user.IsEmailAddressBeenVerifiedByUser)
                            {
                                user.IsUserLoggedOnAtLeastOnce = true;
                                // Go to start of Section::Account SignIn Process
                            }
                            else
                            {
                                // Go to start of Section::Send Reverification Email To User To Confirm Account
                                Console.WriteLine("Go to start of section::send reverification email to user to confirm account");
                            }
                        }
                        if(user.UserSalt != "" && user.UserSalt != result.UserSalt)
                        {
                            Console.WriteLine("Login failed");
                            // We will store a record in ‘LoginsAudit’
                            LoginAudit loginAudit = new LoginAudit();
                            loginAudit.LADateTime = DateTime.UtcNow;
                            contextAccessor = new HttpContextAccessor();
                            loginAudit.LAIpAddress = contextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
                            loginAudit.LALoginTypeId = 1;
                            loginAudit.LAIsSuccess = true;
                            loginAudit.LAIsError = false;
                            loginAudit.LAErrorAnalysis = 1;
                            loginAudit.LAException = "";
                            Console.WriteLine(JsonConvert.SerializeObject(loginAudit));
                            _context.LoginAudits.Add(loginAudit);
                            await _context.SaveChangesAsync();
                            // Display ErrorAnalysis to the user, and allow them to try again.
                            
                        }
                    }
                    if(result.IsUserLoggedOnAtLeastOnce)
                    {
                        if(result.IsEmailAddressBeenVerifiedByUser)
                        {
                            if (user.UserSalt != "" && user.UserSalt == result.UserSalt)
                            {
                                // User Login Success
                                // We will store a record in 'LoginsAudit'
                                LoginAudit loginAudit = new LoginAudit();
                                loginAudit.LADateTime = DateTime.UtcNow;
                                contextAccessor = new HttpContextAccessor();
                                loginAudit.LAIpAddress = contextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
                                loginAudit.LALoginTypeId = 1;
                                loginAudit.LAIsSuccess = true;
                                loginAudit.LAIsError = false;
                                loginAudit.LAErrorAnalysis = 1;
                                _context.LoginAudits.Add(loginAudit);
                                await _context.SaveChangesAsync();
                                // Navigate to the homepage
                            }
                            if(user.UserSalt != "" && user.UserSalt != result.UserSalt)
                            {
                                LoginAudit loginAudit = new LoginAudit();
                                loginAudit.LADateTime = DateTime.UtcNow;
                                contextAccessor = new HttpContextAccessor();
                                loginAudit.LAIpAddress = contextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
                                loginAudit.LALoginTypeId = 1;
                                loginAudit.LAIsSuccess = false;
                                loginAudit.LAIsError = true;
                                loginAudit.LAErrorAnalysis = 1;
                                _context.LoginAudits.Add(loginAudit);
                                await _context.SaveChangesAsync();
                                //Display ErrorAnalysis and go to login
                            }
                        }
                        if(!result.IsEmailAddressBeenVerifiedByUser)
                        {
                            // SECTION::Send Reverification Email To User To Confirm Account

                            // One possible scenarios, this could happen
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

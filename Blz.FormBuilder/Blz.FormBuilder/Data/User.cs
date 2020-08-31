using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Data
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string EmailLinkVerificationCode { get; set; }
        public DateTime EmailLinkVerificationCodeValidUntil { get; set; }
        public bool IsRegisterationConfirmationEmailSent { get; set; }
        public string VerifiedAgainstEmailVerificationRecordId { get; set; }
        public bool IsSuccessfulVerification { get; set; }
        public string LinkUrlAttemped { get; set; }
        public string UserSaltPassword { get; set; }
        public string UserSalt { get; set; }
        public bool IsNewPasswordCreated { get; set; }
        public string NewPasswordCreatedSalt { get; set; }
        public string UserIpAddress { get; set; }
        public DateTime UserCreateTime { get; set; }
        public DateTime TokenValidTime { get; set; }
        public int LoginTypeId { get; set; }
        public int RegisterTypeId { get; set; }
        public bool IsUserLoggedOnAtLeastOnce { get; set; }
        public bool IsEmailAddressBeenVerifiedByUser { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public string ErrorAnalysis { get; set; }
        public string ErrorDescription { get; set; }
    }
}

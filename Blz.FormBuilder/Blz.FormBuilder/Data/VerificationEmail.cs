using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Data
{
    [Table("VerificationEmails")]
    public class VerificationEmail
    {
        [Key]
        public int VEId { get; set; }
        public DateTime VETime { get; set; }
        public string VEIpAddress { get; set; }
        public string VEEmailLinkVerificationCode { get; set; }
        public DateTime VEEmailLinkVerificationCodeValidUntil { get; set; }
        public bool IsNewPasswordCreated { get; set; }
        public string NewPasswordCreatedSALT { get; set; }

    }
}

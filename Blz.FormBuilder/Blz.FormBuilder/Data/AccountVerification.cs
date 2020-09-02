using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Data
{
    [Table("AccountVerifications")]
    public class AccountVerification
    {
        [Key]
        public int AVId { get; set; }
        public DateTime AVTime { get; set; }
        public string AVIpAddress { get; set; }
        public int AVUserId { get; set; }
        public int AVVerifiedAgainstEmailVerificationRecordId { get; set; }
        public bool AVIsSuccessfulVerification { get; set; }
        public string AVLinkUrlAttempted { get; set; }
        public string AVErrorDescription { get; set; }
    }
}

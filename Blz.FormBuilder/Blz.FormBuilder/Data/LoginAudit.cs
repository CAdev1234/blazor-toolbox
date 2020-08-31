using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Data
{
    [Table("LoginAudits")]
    public class LoginAudit
    {
        [Key]
        public int LAId { get; set; }
        public DateTime LADateTime { get; set; }
        public string LAIpAddress { get; set; }
        public int LALoginTypeId { get; set; }
        public bool LAIsSuccess { get; set; }
        public bool LAIsError { get; set; }
        public string LAException { get; set; }
        public int LAErrorAnalysis { get; set; }
    }
}

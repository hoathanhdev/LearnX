using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractructures.Entities
{
    [Table("wsUser")]
    public class User
    {
        
        [Key]
        public int uID { get; set; }
        public string uFullName { get; set; }
        public bool uSex { get; set; }
        public string uInformation { get; set; }
        public string uPhone { get; set; }
        public string uEmail { get; set; }
        public DateTime CreatDate { get; set; }
        public bool isActive { get; set; }
    }
}

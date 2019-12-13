using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFHSIS.Models
{
    public class AspNetUsers
    {
        [Key]
        [Column("UserName")]
        [StringLength(50)]
        public string username { get; set; }

        [Column("PasswordHash")]
        [StringLength(50)]
        public string password { get; set; }

        public int province_id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("useraccounts")]
    public partial class Useraccounts
    {
        [Column("lngEmpID")]
        public int LngEmpId { get; set; }
        [Column("usname")]
        [StringLength(50)]
        public string Usname { get; set; }
        [Column("pwd")]
        [StringLength(50)]
        public string Pwd { get; set; }
        [Column("aclev")]
        [StringLength(50)]
        public string Aclev { get; set; }
    }
}

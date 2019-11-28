using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("Copy Of PROV_DATE1")]
    public partial class CopyOfProvDate1
    {
        [Required]
        [Column("REG_DESC")]
        [StringLength(50)]
        public string RegDesc { get; set; }
        [Required]
        [Column("PROV_DESC")]
        [StringLength(50)]
        public string ProvDesc { get; set; }
        [Required]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("BGY_DATE", TypeName = "datetime2(0)")]
        public DateTime? BgyDate { get; set; }
    }
}

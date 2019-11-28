using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("Prov_Date1")]
    public partial class ProvDate1
    {
        [Required]
        [Column("REG_DESC")]
        [StringLength(50)]
        public string RegDesc { get; set; }
        [Column("PROV_DESC")]
        [StringLength(50)]
        public string ProvDesc { get; set; }
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("BGY_DATE")]
        public DateTime BgyDate { get; set; }
    }
}

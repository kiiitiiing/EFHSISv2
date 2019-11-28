using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("FHUD5")]
    public partial class Fhud5
    {
        [Required]
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }
        [Required]
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }
        [Required]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("BGY_DESC")]
        [StringLength(50)]
        public string BgyDesc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Muncity
    {
        [Required]
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }
        [Required]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("MUN_DESC")]
        [StringLength(50)]
        public string MunDesc { get; set; }
        [Required]
        [Column("CAT")]
        [StringLength(50)]
        public string Cat { get; set; }
        [Column("ILHZ")]
        [StringLength(50)]
        public string Ilhz { get; set; }
    }
}

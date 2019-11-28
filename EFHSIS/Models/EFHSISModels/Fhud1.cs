using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("FHUD1")]
    public partial class Fhud1
    {
        [Required]
        [Column("PROV_CODE")]
        [StringLength(20)]
        public string ProvCode { get; set; }
        [Required]
        [Column("MUN_CODE")]
        [StringLength(20)]
        public string MunCode { get; set; }
        [Required]
        [Column("MUN_DESC")]
        [StringLength(20)]
        public string MunDesc { get; set; }
    }
}

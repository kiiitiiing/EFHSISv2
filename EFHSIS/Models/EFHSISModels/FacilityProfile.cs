using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class FacilityProfile
    {
        [Required]
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }
        [Column("YEAR")]
        [StringLength(50)]
        public string Year { get; set; }
    }
}

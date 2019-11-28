using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class DemographicProfile
    {
        [Required]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Required]
        [Column("BGY_DESC")]
        [StringLength(50)]
        public string BgyDesc { get; set; }
        [Column("HC")]
        [StringLength(50)]
        public string Hc { get; set; }
        [StringLength(50)]
        public string Field1 { get; set; }
    }
}

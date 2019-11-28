using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Region
    {
        [Required]
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }
        [Required]
        [Column("REG_DESC")]
        [StringLength(50)]
        public string RegDesc { get; set; }
    }
}

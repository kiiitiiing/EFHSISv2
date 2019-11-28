using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("Mun_Population")]
    public partial class MunPopulation
    {
        [Required]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Required]
        [Column("POP_YEAR")]
        [StringLength(50)]
        public string PopYear { get; set; }
        [Column("POP_MUN")]
        public int PopMun { get; set; }
    }
}

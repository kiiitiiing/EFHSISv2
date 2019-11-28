using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Population
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
        [Required]
        [Column("POP_YEAR")]
        [StringLength(50)]
        public string PopYear { get; set; }
        [Column("POP_BGY")]
        public int? PopBgy { get; set; }
        [Column("NO_HH")]
        public int? NoHh { get; set; }
        [Column("END_POP_FIL")]
        public int? EndPopFil { get; set; }
        [Column("END_POP_MAL")]
        public int? EndPopMal { get; set; }
        [Column("END_POP_SCH")]
        public int? EndPopSch { get; set; }
    }
}

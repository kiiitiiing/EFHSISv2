using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class OtherIndicators
    {
        [Column("PROGRAM")]
        [StringLength(50)]
        public string Program { get; set; }
        [Column("ACT_IND")]
        [StringLength(50)]
        public string ActInd { get; set; }
        [Column("ACT_M")]
        public int? ActM { get; set; }
        [Column("ACT_F")]
        public int? ActF { get; set; }
    }
}

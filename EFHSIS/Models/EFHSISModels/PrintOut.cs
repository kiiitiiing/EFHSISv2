using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class PrintOut
    {
        [Required]
        [Column("PRT_OUT")]
        [StringLength(50)]
        public string PrtOut { get; set; }
    }
}

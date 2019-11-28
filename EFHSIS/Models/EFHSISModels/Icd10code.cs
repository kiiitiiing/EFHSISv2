using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("ICD10Code")]
    public partial class Icd10code
    {
        [Required]
        [Column("CODE")]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [Column("DESCRIPTION", TypeName = "text")]
        public string Description { get; set; }
    }
}

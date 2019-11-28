using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class OtherPrograms
    {
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("PROGRAM")]
        [StringLength(50)]
        public string Program { get; set; }
        [Column("DATE", TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("Name AutoCorrect Save Failures")]
    public partial class NameAutoCorrectSaveFailures
    {
        [Column("Object Name")]
        [StringLength(50)]
        public string ObjectName { get; set; }
        [Column("Object Type")]
        [StringLength(50)]
        public string ObjectType { get; set; }
        [Column("Failure Reason")]
        [StringLength(50)]
        public string FailureReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("Paste Errors")]
    public partial class PasteErrors
    {
        public string Field0 { get; set; }
    }
}

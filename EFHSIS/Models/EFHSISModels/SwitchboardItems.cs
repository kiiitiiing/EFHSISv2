using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class SwitchboardItems
    {
        [Column("SwitchboardID")]
        public int SwitchboardId { get; set; }
        public int ItemNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemText { get; set; }
        [StringLength(50)]
        public string Command { get; set; }
        [StringLength(50)]
        public string Argument { get; set; }
    }
}

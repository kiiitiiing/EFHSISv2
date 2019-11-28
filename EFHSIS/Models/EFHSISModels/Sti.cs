using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("STI")]
    public partial class Sti
    {
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("DATE", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("PS1")]
        public int Ps1 { get; set; }
        [Column("PS2")]
        public int Ps2 { get; set; }
        [Column("PS3")]
        public int Ps3 { get; set; }
        [Column("PS4")]
        public int Ps4 { get; set; }
    }
}

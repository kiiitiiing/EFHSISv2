using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class MaternalCare
    {
        [Required]
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }
        [Required]
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }
        [Column("DATE", TypeName = "datetime2(0)")]
        public DateTime Date { get; set; }
        [Column("PC1")]
        public int Pc1 { get; set; }
        [Column("PC2")]
        public int Pc2 { get; set; }
        [Column("PC3")]
        public int Pc3 { get; set; }
        [Column("PC4")]
        public int Pc4 { get; set; }
        [Column("PC5")]
        public int Pc5 { get; set; }
        [Column("PP1")]
        public int Pp1 { get; set; }
        [Column("PP2")]
        public int Pp2 { get; set; }
        [Column("PP3")]
        public int Pp3 { get; set; }
        [Column("PP4")]
        public int Pp4 { get; set; }
        [Column("W1049_FE")]
        public int W1049Fe { get; set; }
    }
}

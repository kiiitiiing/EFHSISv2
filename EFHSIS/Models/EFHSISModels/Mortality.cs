using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Mortality
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
        [Column("DATE", TypeName = "datetime2(0)")]
        public DateTime Date { get; set; }
        [Column("TOTDEATH_M")]
        public int TotdeathM { get; set; }
        [Column("TOTDEATH_F")]
        public int TotdeathF { get; set; }
        [Column("INFDEATH_M")]
        public int InfdeathM { get; set; }
        [Column("INFDEATH_F")]
        public int InfdeathF { get; set; }
        [Column("MATDEATH_M")]
        public int MatdeathM { get; set; }
        [Column("MATDEATH_F")]
        public int MatdeathF { get; set; }
        [Column("NEOTET_M")]
        public int NeotetM { get; set; }
        [Column("NEOTET_F")]
        public int NeotetF { get; set; }
        [Column("PRENATDEATH_M")]
        public int PrenatdeathM { get; set; }
        [Column("PRENATDEATH_F")]
        public int PrenatdeathF { get; set; }
        [Column("DEATHUND5_M")]
        public int Deathund5M { get; set; }
        [Column("DEATHUND5_F")]
        public int Deathund5F { get; set; }
        [Column("FD_M")]
        public int FdM { get; set; }
        [Column("FD_F")]
        public int FdF { get; set; }
        [Column("NEON_M")]
        public int NeonM { get; set; }
        [Column("NEON_F")]
        public int NeonF { get; set; }
    }
}

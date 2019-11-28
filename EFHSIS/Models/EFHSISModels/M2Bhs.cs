using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("M2_BHS")]
    public partial class M2Bhs
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
        [Column("DISEASE")]
        [StringLength(255)]
        public string Disease { get; set; }
        [Column("UNDER1_M")]
        public int Under1M { get; set; }
        [Column("UNDER1_F")]
        public int Under1F { get; set; }
        [Column("1_4_M")]
        public int _14M { get; set; }
        [Column("1_4_F")]
        public int _14F { get; set; }
        [Column("5_9_M")]
        public int _59M { get; set; }
        [Column("5_9_F")]
        public int _59F { get; set; }
        [Column("10_14_M")]
        public int _1014M { get; set; }
        [Column("10_14_F")]
        public int _1014F { get; set; }
        [Column("15_19_M")]
        public int _1519M { get; set; }
        [Column("15_19_F")]
        public int _1519F { get; set; }
        [Column("20_24_M")]
        public int _2024M { get; set; }
        [Column("20_24_F")]
        public int _2024F { get; set; }
        [Column("25_29_M")]
        public int _2529M { get; set; }
        [Column("25_29_F")]
        public int _2529F { get; set; }
        [Column("30_34_M")]
        public int _3034M { get; set; }
        [Column("30_34_F")]
        public int _3034F { get; set; }
        [Column("35_39_M")]
        public int _3539M { get; set; }
        [Column("35_39_F")]
        public int _3539F { get; set; }
        [Column("40_44_M")]
        public int _4044M { get; set; }
        [Column("40_44_F")]
        public int _4044F { get; set; }
        [Column("45_49_M")]
        public int _4549M { get; set; }
        [Column("45_49_F")]
        public int _4549F { get; set; }
        [Column("50_54_M")]
        public int _5054M { get; set; }
        [Column("50_54_F")]
        public int _5054F { get; set; }
        [Column("55_59_M")]
        public int _5559M { get; set; }
        [Column("55_59_F")]
        public int _5559F { get; set; }
        [Column("60_64_M")]
        public int _6064M { get; set; }
        [Column("60_64_F")]
        public int _6064F { get; set; }
        [Column("65ABOVE_M")]
        public int _65aboveM { get; set; }
        [Column("65ABOVE_F")]
        public int _65aboveF { get; set; }
        [Column("65_69_M")]
        public int _6569M { get; set; }
        [Column("65_69_F")]
        public int _6569F { get; set; }
        [Column("70ABOVE_M")]
        public int _70aboveM { get; set; }
        [Column("70ABOVE_F")]
        public int _70aboveF { get; set; }
    }
}

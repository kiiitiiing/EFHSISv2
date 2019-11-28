using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class EnvironmentalHealth
    {
        [Required]
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
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Required]
        [Column("YEAR_ENV")]
        [StringLength(50)]
        public string YearEnv { get; set; }
        [Column("HHWATER_LEVEL1")]
        public int HhwaterLevel1 { get; set; }
        [Column("HHWATER_LEVEL2")]
        public int HhwaterLevel2 { get; set; }
        [Column("HHWATER_LEVEL3")]
        public int HhwaterLevel3 { get; set; }
        [Column("HHSANTOILET")]
        public int Hhsantoilet { get; set; }
        [Column("HHWASTE")]
        public int Hhwaste { get; set; }
        [Column("HHSANFAC")]
        public int Hhsanfac { get; set; }
        [Column("FOODEST")]
        public int Foodest { get; set; }
        [Column("FOODEST_SAN")]
        public int FoodestSan { get; set; }
        [Column("FOODHAND")]
        public int Foodhand { get; set; }
        [Column("FOODHAND_HC")]
        public int FoodhandHc { get; set; }
        [Column("SALT_TEST")]
        public int SaltTest { get; set; }
        [Column("SALT_TESTIOD")]
        public int SaltTestiod { get; set; }
    }
}

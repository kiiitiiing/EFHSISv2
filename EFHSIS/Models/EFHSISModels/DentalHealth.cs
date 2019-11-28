using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class DentalHealth
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
        [Column("OFC_M")]
        public int OfcM { get; set; }
        [Column("OFC_F")]
        public int OfcF { get; set; }
        [Column("CHILD_BOHC_M")]
        public int ChildBohcM { get; set; }
        [Column("CHILD_BOHC_F")]
        public int ChildBohcF { get; set; }
        [Column("AY_BOHC_M")]
        public int AyBohcM { get; set; }
        [Column("_3_Adolescent_and_Youth_10_24_yo_given_BOHC")]
        public int _3AdolescentAndYouth1024YoGivenBohc { get; set; }
        [Column("PREG_BOHC_M")]
        public int PregBohcM { get; set; }
        [Column("PREG_BOHC_F")]
        public int PregBohcF { get; set; }
        [Column("OLDPER_BOHC_M")]
        public int OldperBohcM { get; set; }
        [Column("OLDPER_BOHC_F")]
        public int OldperBohcF { get; set; }
    }
}

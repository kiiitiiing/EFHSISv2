using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Leprocy
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
        [Column("LEPCASE_M")]
        public int LepcaseM { get; set; }
        [Column("LEPCASE_F")]
        public int LepcaseF { get; set; }
        [Column("LEPCASE15_M")]
        public int Lepcase15M { get; set; }
        [Column("LEPCASE15_F")]
        public int Lepcase15F { get; set; }
        [Column("NEWDET_M")]
        public int NewdetM { get; set; }
        [Column("NEWDET_F")]
        public int NewdetF { get; set; }
        [Column("NEWDET2_M")]
        public int Newdet2M { get; set; }
        [Column("NEWDET2_F")]
        public int Newdet2F { get; set; }
        [Column("CASECURED_M")]
        public int CasecuredM { get; set; }
        [Column("CASECURED_F")]
        public int CasecuredF { get; set; }
    }
}

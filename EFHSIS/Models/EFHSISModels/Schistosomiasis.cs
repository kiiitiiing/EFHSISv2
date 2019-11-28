using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Schistosomiasis
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
        public DateTime? Date { get; set; }
        [Column("SYMPCASE_M")]
        public int SympcaseM { get; set; }
        [Column("SYMPCASE_F")]
        public int SympcaseF { get; set; }
        [Column("POSCASE_M")]
        public int PoscaseM { get; set; }
        [Column("POSCASE_F")]
        public int PoscaseF { get; set; }
        [Column("CASEX_LOW_M")]
        public int CasexLowM { get; set; }
        [Column("CASEX_LOW_F")]
        public int CasexLowF { get; set; }
        [Column("CASEX_MED_M")]
        public int CasexMedM { get; set; }
        [Column("CASEX_MED_F")]
        public int CasexMedF { get; set; }
        [Column("CASEX_HIGH_M")]
        public int CasexHighM { get; set; }
        [Column("CASEX_HIGH_F")]
        public int CasexHighF { get; set; }
        [Column("CASETX_M")]
        public int CasetxM { get; set; }
        [Column("CASETX_F")]
        public int CasetxF { get; set; }
        [Column("CASEREF_M")]
        public int CaserefM { get; set; }
        [Column("CASEREF_F")]
        public int CaserefF { get; set; }
        [Column("COMPCASE_M")]
        public int CompcaseM { get; set; }
        [Column("COMPCASE_F")]
        public int CompcaseF { get; set; }
        [Column("CASEX_M")]
        public int CasexM { get; set; }
        [Column("CASEX_F")]
        public int CasexF { get; set; }
        [Column("POSCASE_LOW_M")]
        public int PoscaseLowM { get; set; }
        [Column("POSCASE_LOW_F")]
        public int PoscaseLowF { get; set; }
        [Column("POSCASE_MED_M")]
        public int PoscaseMedM { get; set; }
        [Column("POSCASE_MED_F")]
        public int PoscaseMedF { get; set; }
        [Column("POSCASE_HIGH_M")]
        public int PoscaseHighM { get; set; }
        [Column("POSCASE_HIGH_F")]
        public int PoscaseHighF { get; set; }
    }
}

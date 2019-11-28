using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Filariasis
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
        [Column("CASEEXAM_M")]
        public int CaseexamM { get; set; }
        [Column("CASEEXAM_F")]
        public int CaseexamF { get; set; }
        [Column("CASEPOS_M")]
        public int CaseposM { get; set; }
        [Column("CASEPOS_F")]
        public int CaseposF { get; set; }
        [Column("MF_M")]
        public int MfM { get; set; }
        [Column("MF_F")]
        public int MfF { get; set; }
        [Column("MDA_M")]
        public int MdaM { get; set; }
        [Column("MDA_F")]
        public int MdaF { get; set; }
        [Column("ADENOCASE_M")]
        public int AdenocaseM { get; set; }
        [Column("ADENOCASE_F")]
        public int AdenocaseF { get; set; }
        [Column("NOCASE_M")]
        public int NocaseM { get; set; }
        [Column("NOCASE_F")]
        public int NocaseF { get; set; }
    }
}

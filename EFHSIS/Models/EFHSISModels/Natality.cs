using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Natality
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
        [Column("LBTOT_M")]
        public int LbtotM { get; set; }
        [Column("LBTOT_F")]
        public int LbtotF { get; set; }
        [Column("BW2500UP_M")]
        public int Bw2500upM { get; set; }
        [Column("BW2500UP_F")]
        public int Bw2500upF { get; set; }
        [Column("BW2500LESS_M")]
        public int Bw2500lessM { get; set; }
        [Column("BW2500LESS_F")]
        public int Bw2500lessF { get; set; }
        [Column("BWNK_M")]
        public int BwnkM { get; set; }
        [Column("BWNK_F")]
        public int BwnkF { get; set; }
        [Column("ATTDOC_M")]
        public int AttdocM { get; set; }
        [Column("ATTDOC_F")]
        public int AttdocF { get; set; }
        [Column("ATTNURSE_M")]
        public int AttnurseM { get; set; }
        [Column("ATTNURSE_F")]
        public int AttnurseF { get; set; }
        [Column("ATTMIDW_M")]
        public int AttmidwM { get; set; }
        [Column("ATTMIDW_F")]
        public int AttmidwF { get; set; }
        [Column("ATTTH_M")]
        public int AttthM { get; set; }
        [Column("ATTTH_F")]
        public int AttthF { get; set; }
        [Column("ATTOTHER_M")]
        public int AttotherM { get; set; }
        [Column("ATTOTHER_F")]
        public int AttotherF { get; set; }
        [Column("ATTUNK_M")]
        public int AttunkM { get; set; }
        [Column("ATTUNK_F")]
        public int AttunkF { get; set; }
        [Column("TYPEPREG_NORM_M")]
        public int TypepregNormM { get; set; }
        [Column("TYPEPREG_NORM_F")]
        public int TypepregNormF { get; set; }
        [Column("TYPEPREG_RISK_M")]
        public int TypepregRiskM { get; set; }
        [Column("TYPEPREG_RISK_F")]
        public int TypepregRiskF { get; set; }
        [Column("TYPEPREG_NK_M")]
        public int TypepregNkM { get; set; }
        [Column("TYPEPREG_NK_F")]
        public int TypepregNkF { get; set; }
        [Column("NORMDEL_HOME_M")]
        public int NormdelHomeM { get; set; }
        [Column("NORMDEL_HOME_F")]
        public int NormdelHomeF { get; set; }
        [Column("NORMDEL_HOSP_M")]
        public int NormdelHospM { get; set; }
        [Column("NORMDEL_HOSP_F")]
        public int NormdelHospF { get; set; }
        [Column("NORMDEL_OTH_M")]
        public int NormdelOthM { get; set; }
        [Column("NORMDEL_OTH_F")]
        public int NormdelOthF { get; set; }
        [Column("OTD_HOME_M")]
        public int OtdHomeM { get; set; }
        [Column("OTD_HOME_F")]
        public int OtdHomeF { get; set; }
        [Column("OTD_HOSP_M")]
        public int OtdHospM { get; set; }
        [Column("OTD_HOSP_F")]
        public int OtdHospF { get; set; }
        [Column("OTD_OTHER_M")]
        public int OtdOtherM { get; set; }
        [Column("OTD_OTHER_F")]
        public int OtdOtherF { get; set; }
        [Column("NOPREG_M")]
        public int NopregM { get; set; }
        [Column("NOPREG_F")]
        public int NopregF { get; set; }
        [Column("FDTOT_M")]
        public int FdtotM { get; set; }
        [Column("FDTOT_F")]
        public int FdtotF { get; set; }
        [Column("ABRTOT_M")]
        public int AbrtotM { get; set; }
        [Column("ABRTOT_F")]
        public int AbrtotF { get; set; }
        [Column("NSD_M")]
        public int NsdM { get; set; }
        [Column("NSD_F")]
        public int NsdF { get; set; }
        [Column("OTD_M")]
        public int OtdM { get; set; }
        [Column("OTD_F")]
        public int OtdF { get; set; }
        [Column("PREG_TOT")]
        public int PregTot { get; set; }
        [Column("OUT_LB")]
        public int OutLb { get; set; }
        [Column("OUT_FD")]
        public int OutFd { get; set; }
        [Column("OUT_ABR")]
        public int OutAbr { get; set; }
    }
}

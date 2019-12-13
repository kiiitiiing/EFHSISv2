using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class ChildCare
    {
        [NotMapped]
        [Column("REG_CODE")]
        [StringLength(50)]
        public string RegCode { get; set; }

        [NotMapped]
        [Column("PROV_CODE")]
        [StringLength(50)]
        public string ProvCode { get; set; }

        [NotMapped]
        [Column("MUN_CODE")]
        [StringLength(50)]
        public string MunCode { get; set; }

        [NotMapped]
        [Column("BGY_CODE")]
        [StringLength(50)]
        public string BgyCode { get; set; }

        [NotMapped]
        [Column("DATE", TypeName = "datetime2(0)")]
        public DateTime? Date { get; set; }
        [Column("IMM_BCG_M")]
        public int ImmBcgM { get; set; }
        [Column("IMM_BCG_F")]
        public int ImmBcgF { get; set; }
        [Column("IMM_DPT1_M")]
        public int ImmDpt1M { get; set; }
        [Column("IMM_DPT1_F")]
        public int ImmDpt1F { get; set; }
        [Column("IMM_DPT2_M")]
        public int ImmDpt2M { get; set; }
        [Column("IMM_DPT2_F")]
        public int ImmDpt2F { get; set; }
        [Column("IMM_DPT3_M")]
        public int ImmDpt3M { get; set; }
        [Column("IMM_DPT3_F")]
        public int ImmDpt3F { get; set; }
        [Column("IMM_OPV1_M")]
        public int ImmOpv1M { get; set; }
        [Column("IMM_OPV1_F")]
        public int ImmOpv1F { get; set; }
        [Column("IMM_OPV2_M")]
        public int ImmOpv2M { get; set; }
        [Column("IMM_OPV2_F")]
        public int ImmOpv2F { get; set; }
        [Column("IMM_OPV3_M")]
        public int ImmOpv3M { get; set; }
        [Column("IMM_OPV3_F")]
        public int ImmOpv3F { get; set; }
        [Column("IMM_HEPAB1WIN24_M")]
        public int ImmHepab1win24M { get; set; }
        [Column("IMM_HEPAB1WIN24_F")]
        public int ImmHepab1win24F { get; set; }
        [Column("IMM_HEPAB124_M")]
        public int ImmHepab124M { get; set; }
        [Column("IMM_HEPAB124_F")]
        public int ImmHepab124F { get; set; }
        [Column("IMM_HEPAB2_M")]
        public int ImmHepab2M { get; set; }
        [Column("IMM_HEPAB2_F")]
        public int ImmHepab2F { get; set; }
        [Column("IMM_HEPAB3_M")]
        public int ImmHepab3M { get; set; }
        [Column("IMM_HEPAB3_F")]
        public int ImmHepab3F { get; set; }
        [Column("IMM_MEAS_M")]
        public int ImmMeasM { get; set; }
        [Column("IMM_MEAS_F")]
        public int ImmMeasF { get; set; }
        [Column("FIC_M")]
        public int FicM { get; set; }
        [Column("FIC_F")]
        public int FicF { get; set; }
        [Column("CIC_M")]
        public int CicM { get; set; }
        [Column("CIC_F")]
        public int CicF { get; set; }
        [Column("CPB_M")]
        public int CpbM { get; set; }
        [Column("CPB_F")]
        public int CpbF { get; set; }
        [Column("INF_AGE_M")]
        public int InfAgeM { get; set; }
        [Column("INF_AGE_F")]
        public int InfAgeF { get; set; }
        [Column("INF_BREAST_M")]
        public int InfBreastM { get; set; }
        [Column("INF_BREAST_F")]
        public int InfBreastF { get; set; }
        [Column("INF_NEWBS_M")]
        public int InfNewbsM { get; set; }
        [Column("INF_NEWBS_F")]
        public int InfNewbsF { get; set; }
        [Column("INF_VITA611_M")]
        public int InfVita611M { get; set; }
        [Column("INF_VITA611_F")]
        public int InfVita611F { get; set; }
        [Column("INF_VITA1259_M")]
        public int InfVita1259M { get; set; }
        [Column("INF_VITA1259_F")]
        public int InfVita1259F { get; set; }
        [Column("INF_VITA6071_M")]
        public int InfVita6071M { get; set; }
        [Column("INF_VITA6071_F")]
        public int InfVita6071F { get; set; }
        [Column("SICK_611_M")]
        public int Sick611M { get; set; }
        [Column("SICK_611_F")]
        public int Sick611F { get; set; }
        [Column("SICK_1259_M")]
        public int Sick1259M { get; set; }
        [Column("SICK_1259_F")]
        public int Sick1259F { get; set; }
        [Column("SICK_6071_M")]
        public int Sick6071M { get; set; }
        [Column("SICK_6071_F")]
        public int Sick6071F { get; set; }
        [Column("SICKVITA_611_M")]
        public int Sickvita611M { get; set; }
        [Column("SICKVITA_611_F")]
        public int Sickvita611F { get; set; }
        [Column("SICKVITA_1259_M")]
        public int Sickvita1259M { get; set; }
        [Column("SICKVITA_1259_F")]
        public int Sickvita1259F { get; set; }
        [Column("SICKVITA_6071_M")]
        public int Sickvita6071M { get; set; }
        [Column("SICKVITA_6071_F")]
        public int Sickvita6071F { get; set; }
        [Column("INF26LBWNS_M")]
        public int Inf26lbwnsM { get; set; }
        [Column("INF26LBWNS_F")]
        public int Inf26lbwnsF { get; set; }
        [Column("INF26FE_M")]
        public int Inf26feM { get; set; }
        [Column("INF26FE_F")]
        public int Inf26feF { get; set; }
        [Column("ANECHILDNS_M")]
        public int AnechildnsM { get; set; }
        [Column("ANECHILDNS_F")]
        public int AnechildnsF { get; set; }
        [Column("ANECHILDFE_M")]
        public int AnechildfeM { get; set; }
        [Column("ANECHILDFE_F")]
        public int AnechildfeF { get; set; }
        [Column("DIARRNC_M")]
        public int DiarrncM { get; set; }
        [Column("DIARRNC_F")]
        public int DiarrncF { get; set; }
        [Column("DIARRORT_M")]
        public int DiarrortM { get; set; }
        [Column("DIARRORT_F")]
        public int DiarrortF { get; set; }
        [Column("DIARRORS_M")]
        public int DiarrorsM { get; set; }
        [Column("DIARRORS_F")]
        public int DiarrorsF { get; set; }
        [Column("DIARRORSZ_M")]
        public int DiarrorszM { get; set; }
        [Column("DIARRORSZ_F")]
        public int DiarrorszF { get; set; }
        [Column("PNEUNC_M")]
        public int PneuncM { get; set; }
        [Column("PNEUNC_F")]
        public int PneuncF { get; set; }
        [Column("PNEUGT_M")]
        public int PneugtM { get; set; }
        [Column("PNEUGT_F")]
        public int PneugtF { get; set; }
        [Column("IMM_PENTA1_M")]
        public int ImmPenta1M { get; set; }
        [Column("IMM_PENTA1_F")]
        public int ImmPenta1F { get; set; }
        [Column("IMM_PENTA2_M")]
        public int ImmPenta2M { get; set; }
        [Column("IMM_PENTA2_F")]
        public int ImmPenta2F { get; set; }
        [Column("IMM_PENTA3_M")]
        public int ImmPenta3M { get; set; }
        [Column("IMM_PENTA3_F")]
        public int ImmPenta3F { get; set; }
        [Column("IMM_MCV1_M")]
        public int ImmMcv1M { get; set; }
        [Column("IMM_MCV1_F")]
        public int ImmMcv1F { get; set; }
        [Column("IMM_MCV2_M")]
        public int ImmMcv2M { get; set; }
        [Column("IMM_MCV2_F")]
        public int ImmMcv2F { get; set; }
        [Column("IMM_ROTA1_M")]
        public int ImmRota1M { get; set; }
        [Column("IMM_ROTA1_F")]
        public int ImmRota1F { get; set; }
        [Column("IMM_ROTA2_M")]
        public int ImmRota2M { get; set; }
        [Column("IMM_ROTA2_F")]
        public int ImmRota2F { get; set; }
        [Column("IMM_ROTA3_M")]
        public int ImmRota3M { get; set; }
        [Column("IMM_ROTA3_F")]
        public int ImmRota3F { get; set; }
        [Column("IMM_PCV1_M")]
        public int ImmPcv1M { get; set; }
        [Column("IMM_PCV1_F")]
        public int ImmPcv1F { get; set; }
        [Column("IMM_PCV2_M")]
        public int ImmPcv2M { get; set; }
        [Column("IMM_PCV2_F")]
        public int ImmPcv2F { get; set; }
        [Column("IMM_PCV3_M")]
        public int ImmPcv3M { get; set; }
        [Column("IMM_PCV3_F")]
        public int ImmPcv3F { get; set; }
        [Column("INF_FOOD_M")]
        public int InfFoodM { get; set; }
        [Column("INF_FOOD_F")]
        public int InfFoodF { get; set; }
        [Column("INF611FE_M")]
        public int Inf611feM { get; set; }
        [Column("INF611FE_F")]
        public int Inf611feF { get; set; }
        [Column("INF1259FE_M")]
        public int Inf1259feM { get; set; }
        [Column("INF1259FE_F")]
        public int Inf1259feF { get; set; }
        [Column("INF611MNP_M")]
        public int Inf611mnpM { get; set; }
        [Column("INF611MNP_F")]
        public int Inf611mnpF { get; set; }
        [Column("INF1223MNP_M")]
        public int Inf1223mnpM { get; set; }
        [Column("INF1223MNP_F")]
        public int Inf1223mnpF { get; set; }
        [Column("CHILD_1259DW_M")]
        public int Child1259dwM { get; set; }
        [Column("CHILD_1259DW_F")]
        public int Child1259dwF { get; set; }
        [Column("INF25LBWFE_M")]
        public int Inf25lbwfeM { get; set; }
        [Column("INF25LBWFE_F")]
        public int Inf25lbwfeF { get; set; }
        [Column("INF25LBWNS_M")]
        public int Inf25lbwnsM { get; set; }
        [Column("INF25LBWNS_F")]
        public int Inf25lbwnsF { get; set; }
        [Column("ANECHILD611_M")]
        public int Anechild611M { get; set; }
        [Column("ANECHILD611_F")]
        public int Anechild611F { get; set; }
        [Column("ANECHILD611FE_M")]
        public int Anechild611feM { get; set; }
        [Column("ANECHILD611FE_F")]
        public int Anechild611feF { get; set; }
        [Column("ANECHILD1259_M")]
        public int Anechild1259M { get; set; }
        [Column("ANECHILD1259_F")]
        public int Anechild1259F { get; set; }
        [Column("ANECHILD1259FE_M")]
        public int Anechild1259feM { get; set; }
        [Column("ANECHILD1259FE_F")]
        public int Anechild1259feF { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    [Table("NatalityTCL")]
    public partial class NatalityTcl
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
        [Column("LBTCL_M")]
        public int LbtclM { get; set; }
        [Column("LBTCL_F")]
        public int LbtclF { get; set; }
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
        [Column("NDELHF_RHUM")]
        public int NdelhfRhum { get; set; }
        [Column("NDELHF_RHUF")]
        public int NdelhfRhuf { get; set; }
        [Column("NDELHF_HOSPM")]
        public int NdelhfHospm { get; set; }
        [Column("NDELHF_HOSPF")]
        public int NdelhfHospf { get; set; }
        [Column("NDELHF_BHSM")]
        public int NdelhfBhsm { get; set; }
        [Column("NDELHF_BHSF")]
        public int NdelhfBhsf { get; set; }
        [Column("NDELHF_LYM")]
        public int NdelhfLym { get; set; }
        [Column("NDELHF_LYF")]
        public int NdelhfLyf { get; set; }
        [Column("NDELNID_HMM")]
        public int NdelnidHmm { get; set; }
        [Column("NDELNID_HMF")]
        public int NdelnidHmf { get; set; }
        [Column("NDELNID_OTM")]
        public int NdelnidOtm { get; set; }
        [Column("NDELNID_OTF")]
        public int NdelnidOtf { get; set; }
        [Column("ODELHF_HOSPM")]
        public int OdelhfHospm { get; set; }
        [Column("ODELHF_HOSPF")]
        public int OdelhfHospf { get; set; }
        [Column("ODELHF_OTM")]
        public int OdelhfOtm { get; set; }
        [Column("ODELHF_OTF")]
        public int OdelhfOtf { get; set; }
        [Column("POUT_LBM")]
        public int PoutLbm { get; set; }
        [Column("POUT_LBF")]
        public int PoutLbf { get; set; }
        [Column("POUT_FDM")]
        public int PoutFdm { get; set; }
        [Column("POUT_FDF")]
        public int PoutFdf { get; set; }
        [Column("POUT_ABM")]
        public int PoutAbm { get; set; }
        [Column("POUT_ABF")]
        public int PoutAbf { get; set; }
    }
}

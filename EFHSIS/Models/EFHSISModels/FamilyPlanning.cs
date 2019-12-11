using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class FamilyPlanning
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
        public DateTime Date { get; set; }
        [Column("PREV_FS")]
        public int PrevFs { get; set; }
        [Column("PREV_MS")]
        public int PrevMs { get; set; }
        [Column("PREV_PILLS")]
        public int PrevPills { get; set; }
        [Column("PREV_IUD")]
        public int PrevIud { get; set; }
        [Column("PREV_DMPA")]
        public int PrevDmpa { get; set; }
        [Column("PREV_NFPCM")]
        public int PrevNfpcm { get; set; }
        [Column("PREV_NFPBBT")]
        public int PrevNfpbbt { get; set; }
        [Column("PREV_NFPLAM")]
        public int PrevNfplam { get; set; }
        [Column("PREV_NFPSDM")]
        public int PrevNfpsdm { get; set; }
        [Column("PREV_NFPSTM")]
        public int PrevNfpstm { get; set; }
        [Column("PREV_CONDOM")]
        public int PrevCondom { get; set; }
        [Column("TNA_FS")]
        public int TnaFs { get; set; }
        [Column("TNA_MS")]
        public int TnaMs { get; set; }
        [Column("TNA_PILLS")]
        public int TnaPills { get; set; }
        [Column("TNA_IUD")]
        public int TnaIud { get; set; }
        [Column("TNA_DMPA")]
        public int TnaDmpa { get; set; }
        [Column("TNA_NFPCM")]
        public int TnaNfpcm { get; set; }
        [Column("TNA_NFPBBT")]
        public int TnaNfpbbt { get; set; }
        [Column("TNA_NFPLAM")]
        public int TnaNfplam { get; set; }
        [Column("TNA_NFPSDM")]
        public int TnaNfpsdm { get; set; }
        [Column("TNA_NFPSTM")]
        public int TnaNfpstm { get; set; }
        [Column("TNA_CONDOM")]
        public int TnaCondom { get; set; }
        [Column("TOA_FS")]
        public int ToaFs { get; set; }
        [Column("TOA_MS")]
        public int ToaMs { get; set; }
        [Column("TOA_PILLS")]
        public int ToaPills { get; set; }
        [Column("TOA_IUD")]
        public int ToaIud { get; set; }
        [Column("TOA_DMPA")]
        public int ToaDmpa { get; set; }
        [Column("TOA_NFPCM")]
        public int ToaNfpcm { get; set; }
        [Column("TOA_NFPBBT")]
        public int ToaNfpbbt { get; set; }
        [Column("TOA_NFPLAM")]
        public int ToaNfplam { get; set; }
        [Column("TOA_NFPSDM")]
        public int ToaNfpsdm { get; set; }
        [Column("TOA_NFPSTM")]
        public int ToaNfpstm { get; set; }
        [Column("TOA_CONDOM")]
        public int ToaCondom { get; set; }
        [Column("TDO_FS")]
        public int TdoFs { get; set; }
        [Column("TDO_MS")]
        public int TdoMs { get; set; }
        [Column("TDO_PILLS")]
        public int TdoPills { get; set; }
        [Column("TDO_IUD")]
        public int TdoIud { get; set; }
        [Column("TDO_DMPA")]
        public int TdoDmpa { get; set; }
        [Column("TDO_NFPCM")]
        public int TdoNfpcm { get; set; }
        [Column("TDO_NFPBBT")]
        public int TdoNfpbbt { get; set; }
        [Column("TDO_NFPLAM")]
        public int TdoNfplam { get; set; }
        [Column("TDO_NFPSDM")]
        public int TdoNfpsdm { get; set; }
        [Column("TDO_NFPSTM")]
        public int TdoNfpstm { get; set; }
        [Column("TDO_CONDOM")]
        public int TdoCondom { get; set; }
        [Column("TCU_FS")]
        public int TcuFs { get; set; }
        [Column("TCU_MS")]
        public int TcuMs { get; set; }
        [Column("TCU_PILLS")]
        public int TcuPills { get; set; }
        [Column("TCU_IUD")]
        public int TcuIud { get; set; }
        [Column("TCU_DMPA")]
        public int TcuDmpa { get; set; }
        [Column("TCU_NFPCM")]
        public int TcuNfpcm { get; set; }
        [Column("TCU_NFPBBT")]
        public int TcuNfpbbt { get; set; }
        [Column("TCU_NFPLAM")]
        public int TcuNfplam { get; set; }
        [Column("TCU_NFPSDM")]
        public int TcuNfpsdm { get; set; }
        [Column("TCU_NFPSTM")]
        public int TcuNfpstm { get; set; }
        [Column("TCU_CONDOM")]
        public int TcuCondom { get; set; }
        [Column("TEMP_FS")]
        public int TempFs { get; set; }
        [Column("TEMP_MS")]
        public int TempMs { get; set; }
        [Column("TEMP_PILLS")]
        public int TempPills { get; set; }
        [Column("TEMP_IUD")]
        public int TempIud { get; set; }
        [Column("TEMP_DMPA")]
        public int TempDmpa { get; set; }
        [Column("TEMP_NFPCM")]
        public int TempNfpcm { get; set; }
        [Column("TEMP_NFPBBT")]
        public int TempNfpbbt { get; set; }
        [Column("TEMP_NFPLAM")]
        public int TempNfplam { get; set; }
        [Column("TEMP_NFPSDM")]
        public int TempNfpsdm { get; set; }
        [Column("TEMP_NFPSTM")]
        public int TempNfpstm { get; set; }
        [Column("TEMP_CONDOM")]
        public int TempCondom { get; set; }
        [Column("PREV_CONDOM_F")]
        public int PrevCondomF { get; set; }
        [Column("PREV_IMPLANT")]
        public int PrevImplant { get; set; }
        [Column("TNA_CONDOM_F")]
        public int TnaCondomF { get; set; }
        [Column("TNA_IMPLANT")]
        public int TnaImplant { get; set; }
        [Column("TOA_CONDOM_F")]
        public int ToaCondomF { get; set; }
        [Column("TOA_IMPLANT")]
        public int ToaImplant { get; set; }
        [Column("TDO_CONDOM_F")]
        public int TdoCondomF { get; set; }
        [Column("TDO_IMPLANT")]
        public int TdoImplant { get; set; }
        [Column("TCU_CONDOM_F")]
        public int TcuCondomF { get; set; }
        [Column("TCU_IMPLANT")]
        public int TcuImplant { get; set; }
        [Column("TEMP_CONDOM_F")]
        public int TempCondomF { get; set; }
        [Column("TEMP_IMPLANT")]
        public int TempImplant { get; set; }
    }
}

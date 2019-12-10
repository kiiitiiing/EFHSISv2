using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public  class Tuberculosis
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
        [Column("DATE", TypeName = "datetime")]
        public DateTime Date { get; set; }


        [Column("TBSYMP_M")]
        public int TbsympM { get; set; }


        [Column("TBSYMP_F")]
        public int TbsympF { get; set; }


        [Column("SMEARPOS_M")]
        public int SmearposM { get; set; }


        [Column("SMEARPOS_F")]
        public int SmearposF { get; set; }


        [Column("NEWSMEAR_M")]
        public int NewsmearM { get; set; }


        [Column("NEWSMEAR_F")]
        public int NewsmearF { get; set; }


        [Column("NWSMEARPOS_M")]
        public int NwsmearposM { get; set; }


        [Column("NWSMEARPOS_F")]
        public int NwsmearposF { get; set; }


        [Column("SMEARET_M")]
        public int SmearetM { get; set; }

        [Column("SMEARET_F")]
        public int SmearetF { get; set; }


        [Column("SMEARET_CURED_M")]
        public int SmearetCuredM { get; set; }

   
        [Column("SMEARET_CURED_F")]
        public int SmearetCuredF { get; set; }


        [Column("SMEARET_REL_M")]
        public int SmearetRelM { get; set; }


        [Column("SMEARET_REL_F")]
        public int SmearetRelF { get; set; }

        [Column("SMEARET_TXF_M")]
        public int SmearetTxfM { get; set; }


        [Column("SMEARET_TXF_F")]
        public int SmearetTxfF { get; set; }


        [Column("SMEARET_RAD_M")]
        public int SmearetRadM { get; set; }


        [Column("SMEARET_RAD_F")]
        public int SmearetRadF { get; set; }


        [Column("SMEARET_OTB_M")]
        public int SmearetOtbM { get; set; }


        [Column("SMEARET_OTB_F")]
        public int SmearetOtbF { get; set; }


        [Column("SMEARET_CURED_REL_M")]
        public int SmearetCuredRelM { get; set; }

 
        [Column("SMEARET_CURED_REL_F")]
        public int SmearetCuredRelF { get; set; }


        [Column("SMEARET_CURED_TXF_M")]
        public int SmearetCuredTxfM { get; set; }


        [Column("SMEARET_CURED_TXF_F")]
        public int SmearetCuredTxfF { get; set; }


        [Column("SMEARET_CURED_RAD_M")]
        public int SmearetCuredRadM { get; set; }


        [Column("SMEARET_CURED_RAD_F")]
        public int SmearetCuredRadF { get; set; }


        [Column("TOT_TB_M")]
        public int TotTbM { get; set; }

 
        [Column("TOT_TB_F")]
        public int TotTbF { get; set; }


        [Column("TB_ALL_M")]
        public int TbAllM { get; set; }


        [Column("TB_ALL_F")]
        public int TbAllF { get; set; }

        public int max_data { get; set; }
    }
}

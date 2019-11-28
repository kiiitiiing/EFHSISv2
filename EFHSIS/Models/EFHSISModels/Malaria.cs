using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFHSIS.Models.EFHSISModels
{
    public partial class Malaria
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
        [Column("MALCASELESS5_M")]
        public int Malcaseless5M { get; set; }
        [Column("MALCASELESS5_F")]
        public int Malcaseless5F { get; set; }
        [Column("MALCASEMORE5_M")]
        public int Malcasemore5M { get; set; }
        [Column("MALCASEMORE5_F")]
        public int Malcasemore5F { get; set; }
        [Column("CONFMAL_PFAC_M")]
        public int ConfmalPfacM { get; set; }
        [Column("CONFMAL_PFAC_F")]
        public int ConfmalPfacF { get; set; }
        [Column("CONFMAL_PFAC_P")]
        public int ConfmalPfacP { get; set; }
        [Column("CONFMAL_PVIV_M")]
        public int ConfmalPvivM { get; set; }
        [Column("CONFMAL_PVIV_F")]
        public int ConfmalPvivF { get; set; }
        [Column("CONFMAL_PVIV_P")]
        public int ConfmalPvivP { get; set; }
        [Column("CONFMAL_PMAL_M")]
        public int ConfmalPmalM { get; set; }
        [Column("CONFMAL_PMAL_F")]
        public int ConfmalPmalF { get; set; }
        [Column("CONFMAL_PMAL_P")]
        public int ConfmalPmalP { get; set; }
        [Column("CONFMAL_POVA_M")]
        public int ConfmalPovaM { get; set; }
        [Column("CONFMAL_POVA_F")]
        public int ConfmalPovaF { get; set; }
        [Column("CONFMAL_POVA_P")]
        public int ConfmalPovaP { get; set; }
        [Column("METHSLIDE_M")]
        public int MethslideM { get; set; }
        [Column("METHSLIDE_F")]
        public int MethslideF { get; set; }
        [Column("METHRDT_M")]
        public int MethrdtM { get; set; }
        [Column("METHRDT_F")]
        public int MethrdtF { get; set; }
        [Column("HH_ATRISK")]
        public int HhAtrisk { get; set; }
        [Column("HH_ITN")]
        public int HhItn { get; set; }
        [Column("MALDEATH_M")]
        public int MaldeathM { get; set; }
        [Column("MALDEATH_F")]
        public int MaldeathF { get; set; }
        [Column("MALCASE_P")]
        public int MalcaseP { get; set; }
        [Column("POP_LLIN")]
        public int PopLlin { get; set; }
    }
}

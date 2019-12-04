using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EFHSIS.Models.GraphModels
{
    public class ChildCareGraph
    {
        public string PROV_CODE { get; set; }
        public int IMM_BCG_M { get; set; } // 1
        public int IMM_BCG_F { get; set; } // 2
        public int IMM_DPT1_M { get; set; } // 3
        public int IMM_DPT1_F { get; set; } // 4
        public int IMM_DPT2_M { get; set; } // 5
        public int IMM_DPT2_F { get; set; } // 6
        public int IMM_DPT3_M { get; set; } // 7
        public int IMM_DPT3_F { get; set; } // 8
        public int IMM_OPV1_M { get; set; } // 9 
        public int IMM_OPV1_F { get; set; } // 10
        public int IMM_OPV2_M { get; set; } // 11
        public int IMM_OPV2_F { get; set; } // 12
        public int IMM_OPV3_M { get; set; } // 13
        public int IMM_OPV3_F { get; set; } // 14
        public int IMM_HEPAB1WIN24_M { get; set; } // 15
        public int IMM_HEPAB1WIN24_F { get; set; } // 16
        public int IMM_HEPAB124_M { get; set; } // 17
        public int IMM_HEPAB124_F { get; set; } // 18
    }
}

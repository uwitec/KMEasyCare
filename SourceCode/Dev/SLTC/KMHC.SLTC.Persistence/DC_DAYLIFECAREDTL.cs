//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_DAYLIFECAREDTL
    {
        public long SEQNO { get; set; }
        public Nullable<long> ID { get; set; }
        public string TEA9 { get; set; }
        public string SNACKTEA9 { get; set; }
        public string LUNCH { get; set; }
        public string SOUPAMOUNT { get; set; }
        public string TEA14 { get; set; }
        public string SNACKTEA1530 { get; set; }
        public string NOONBREAK { get; set; }
        public string BRUSHINGTEETH { get; set; }
        public string PERINEALWASHING { get; set; }
        public string OTHERCLEAN { get; set; }
        public string SHITAMOUNT { get; set; }
        public string SHITCOLOR { get; set; }
        public string SHITNATURE { get; set; }
        public string URINECOLOR { get; set; }
        public string TOILET { get; set; }
        public string TOILETTIME { get; set; }
        public string EQUIPMENT { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public string DAYOFWEEK { get; set; }
        public string HOLIDAYFLAG { get; set; }
    
        public virtual DC_DAYLIFECAREREC DC_DAYLIFECAREREC { get; set; }
    }
}

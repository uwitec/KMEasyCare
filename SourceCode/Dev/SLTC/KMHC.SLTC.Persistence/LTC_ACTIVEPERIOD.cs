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
    
    public partial class LTC_ACTIVEPERIOD
    {
        public string ORGID { get; set; }
        public Nullable<int> PERIODLENGTH { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public Nullable<decimal> FEE { get; set; }
        public Nullable<System.DateTime> ACTUALENDDATE { get; set; }
    
        public virtual LTC_ORG LTC_ORG { get; set; }
    }
}

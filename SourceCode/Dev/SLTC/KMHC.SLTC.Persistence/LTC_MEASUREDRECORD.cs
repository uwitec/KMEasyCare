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
    
    public partial class LTC_MEASUREDRECORD
    {
        public long ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<System.DateTime> MEASURETIME { get; set; }
        public string MEASUREITEMCODE { get; set; }
        public Nullable<float> MEASUREDVALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public string MEASUREDPERSON { get; set; }
        public string SOURCE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string ORGID { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual LTC_MEASUREITEM LTC_MEASUREITEM { get; set; }
    }
}

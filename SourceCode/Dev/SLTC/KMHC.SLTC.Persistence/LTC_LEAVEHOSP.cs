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
    
    public partial class LTC_LEAVEHOSP
    {
        public LTC_LEAVEHOSP()
        {
            this.LTC_NCIDEDUCTION = new HashSet<LTC_NCIDEDUCTION>();
        }
    
        public int ID { get; set; }
        public Nullable<int> SHOWNUMBER { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public Nullable<decimal> LEHOUR { get; set; }
        public string LENOTE { get; set; }
        public Nullable<System.DateTime> RETURNDATE { get; set; }
        public string ADDRESS { get; set; }
        public string CONTNAME { get; set; }
        public string CONTREL { get; set; }
        public string CONTTEL { get; set; }
        public string LETYPE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string UPDATEBY { get; set; }
        public string ORGID { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual LTC_IPDREG LTC_IPDREG { get; set; }
        public virtual ICollection<LTC_NCIDEDUCTION> LTC_NCIDEDUCTION { get; set; }
    }
}

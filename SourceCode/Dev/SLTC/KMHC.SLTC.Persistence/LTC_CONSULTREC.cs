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
    
    public partial class LTC_CONSULTREC
    {
        public LTC_CONSULTREC()
        {
            this.LTC_CONSULTCALLBACK = new HashSet<LTC_CONSULTCALLBACK>();
        }
    
        public long ID { get; set; }
        public string CONSULTANTNAME { get; set; }
        public Nullable<System.DateTime> CONSULTTIME { get; set; }
        public string CONSULTANTPHONE { get; set; }
        public string APPELLATION { get; set; }
        public string OLDMANNAME { get; set; }
        public string OLDMANSEX { get; set; }
        public Nullable<int> OLDMANAGE { get; set; }
        public string CHANNEL { get; set; }
        public string RESERVATIONBED { get; set; }
        public string EARNESTSTATUS { get; set; }
        public Nullable<float> EARNESTAMOUNT { get; set; }
        public string RECORDBY { get; set; }
        public string REMARK { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
    
        public virtual ICollection<LTC_CONSULTCALLBACK> LTC_CONSULTCALLBACK { get; set; }
    }
}
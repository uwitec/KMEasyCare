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
    
    public partial class NCIA_NURSINGHOMEASSTRECORD
    {
        public NCIA_NURSINGHOMEASSTRECORD()
        {
            this.NCIA_APPCERT = new HashSet<NCIA_APPCERT>();
            this.NCIA_NURSINGHOMEASSTRECORDDETAIL = new HashSet<NCIA_NURSINGHOMEASSTRECORDDETAIL>();
        }
    
        public int NSASSTRECORDID { get; set; }
        public int APPCERTID { get; set; }
        public int TOTALSCORE { get; set; }
        public System.DateTime ASSTDATE { get; set; }
        public int ISEXPIRED { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual ICollection<NCIA_APPCERT> NCIA_APPCERT { get; set; }
        public virtual ICollection<NCIA_NURSINGHOMEASSTRECORDDETAIL> NCIA_NURSINGHOMEASSTRECORDDETAIL { get; set; }
    }
}
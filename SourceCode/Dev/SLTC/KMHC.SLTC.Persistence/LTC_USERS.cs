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
    
    public partial class LTC_USERS
    {
        public LTC_USERS()
        {
            this.LTC_ORG = new HashSet<LTC_ORG>();
            this.LTC_ROLES = new HashSet<LTC_ROLES>();
        }
    
        public int USERID { get; set; }
        public string LOGONNAME { get; set; }
        public string PWD { get; set; }
        public Nullable<System.DateTime> PWDEXPDATE { get; set; }
        public Nullable<int> PWDDURATION { get; set; }
        public Nullable<System.DateTime> LASTLOGONDATE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public string EMPNO { get; set; }
        public bool ISORGCTRL { get; set; }
        public Nullable<bool> PWDENABLE { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<LTC_ORG> LTC_ORG { get; set; }
        public virtual ICollection<LTC_ROLES> LTC_ROLES { get; set; }
    }
}

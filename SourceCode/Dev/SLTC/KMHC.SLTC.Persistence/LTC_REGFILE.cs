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
    
    public partial class LTC_REGFILE
    {
        public LTC_REGFILE()
        {
            this.LTC_IPDREG = new HashSet<LTC_IPDREG>();
        }
    
        public int REGNO { get; set; }
        public string NAME { get; set; }
        public string NICKNAME { get; set; }
        public string RESIDENGNO { get; set; }
        public string SEX { get; set; }
        public Nullable<System.DateTime> BRITHDATE { get; set; }
        public Nullable<int> AGE { get; set; }
        public string IDNO { get; set; }
        public string SSNO { get; set; }
        public string EDUCATION { get; set; }
        public string RACE { get; set; }
        public string POLITICAL { get; set; }
        public string SKILL { get; set; }
        public string WORKCODE { get; set; }
        public string EXPERIENCE { get; set; }
        public string TITLE { get; set; }
        public string HABIT { get; set; }
        public string RELIGIONCODE { get; set; }
        public string LANGUAGE { get; set; }
        public string COMMUNICATETYPE { get; set; }
        public string BRITHPLACE { get; set; }
        public string MERRYFLAG { get; set; }
        public Nullable<int> CHILD_BOY { get; set; }
        public Nullable<int> CHILD_GIRL { get; set; }
        public string CAREGIVER { get; set; }
        public string LIVECONDITION { get; set; }
        public string CONSTELLATIONS { get; set; }
        public string BLOODTYPE { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public string PERSONALHISTORY { get; set; }
        public string FAMILYHISTORY { get; set; }
        public string INFECFLAG { get; set; }
        public string RHTYPE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string UPDATEBY { get; set; }
        public string ORGID { get; set; }
        public string DISEASEDIAG { get; set; }
    
        public virtual ICollection<LTC_IPDREG> LTC_IPDREG { get; set; }
        public virtual LTC_REGDISEASEHIS LTC_REGDISEASEHIS { get; set; }
    }
}

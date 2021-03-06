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
    
    public partial class NCIA_APPHOSP
    {
        public int APPHOSPID { get; set; }
        public Nullable<int> APPCERTID { get; set; }
        public string APPLICANTID { get; set; }
        public string APPHOSPSN { get; set; }
        public string NSID { get; set; }
        public string NAME { get; set; }
        public string GENDER { get; set; }
        public int AGE { get; set; }
        public string IDNO { get; set; }
        public string SSNO { get; set; }
        public int CARETYPE { get; set; }
        public string DOCTORNAME { get; set; }
        public System.DateTime NSENTRYTIME { get; set; }
        public Nullable<System.DateTime> ENTRYTIME { get; set; }
        public Nullable<System.DateTime> LEAVETIME { get; set; }
        public string FAMILYMEMBERNAME { get; set; }
        public string FAMILYMEMBERPHONE { get; set; }
        public string PHONE { get; set; }
        public int MCTYPE { get; set; }
        public string DISEASE { get; set; }
        public string ADDRESS { get; set; }
        public string APPREASON { get; set; }
        public string UPLOADFILES { get; set; }
        public string NSCOMMENT { get; set; }
        public Nullable<System.DateTime> NSOPERATETIME { get; set; }
        public string NSSTAFFNAME { get; set; }
        public Nullable<int> ICRESULT { get; set; }
        public string ICCOMMENT { get; set; }
        public Nullable<System.DateTime> ICOPERATETIME { get; set; }
        public string ICSTAFFNAME { get; set; }
        public string ICID { get; set; }
        public Nullable<int> AGENCYRESULT { get; set; }
        public string AGENCYCOMMENT { get; set; }
        public Nullable<System.DateTime> AGENCYOPERATETIME { get; set; }
        public string AGENCYSTAFFNAME { get; set; }
        public string AGENCYID { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual NCIA_APPCERT NCIA_APPCERT { get; set; }
        public virtual NCIA_APPLICANT NCIA_APPLICANT { get; set; }
    }
}

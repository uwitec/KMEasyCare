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
    
    public partial class LTC_PHARMACISTEVAL
    {
        public long ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<int> INTERVALDAY { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string EVALUATEBY { get; set; }
        public string DISEASEDESC { get; set; }
        public string PIPLELINEDESC { get; set; }
        public string VITALSIGNS { get; set; }
        public string M3VISITREC { get; set; }
        public string DRUGRECORDS { get; set; }
        public Nullable<bool> YEARSOLD85 { get; set; }
        public Nullable<bool> DRUG9TYPE { get; set; }
        public Nullable<bool> ADRSFLAG { get; set; }
        public Nullable<bool> SPECTYPEDRGFLAG { get; set; }
        public string SPECTYPEDRUGDESC { get; set; }
        public Nullable<bool> SPECDRUGFLAG { get; set; }
        public string SPECDRUGDESC { get; set; }
        public string INTERACTION { get; set; }
        public string SUGGESTION { get; set; }
        public Nullable<bool> MILLSFLAG { get; set; }
        public Nullable<bool> DEPTVISIT3 { get; set; }
        public string NEXTEVALUATEBY { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string MULTIPLEFLAG { get; set; }
        public string ORGID { get; set; }
    }
}
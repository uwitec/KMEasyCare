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
    
    public partial class DC_EVALQUESTION
    {
        public DC_EVALQUESTION()
        {
            this.DC_EVALQUESTIONRESULT = new HashSet<DC_EVALQUESTIONRESULT>();
        }
    
        public long RECORDID { get; set; }
        public Nullable<long> ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public string REGNO { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public string QUESTIONCODE { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string EVALRESULT { get; set; }
        public string DESCRIPTION { get; set; }
        public string ORGID { get; set; }
    
        public virtual DC_NURSEINGPLANEVAL DC_NURSEINGPLANEVAL { get; set; }
        public virtual ICollection<DC_EVALQUESTIONRESULT> DC_EVALQUESTIONRESULT { get; set; }
    }
}

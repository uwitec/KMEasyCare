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
    
    public partial class LTC_COSTGROUP
    {
        public LTC_COSTGROUP()
        {
            this.LTC_COSTGROUPDTL = new HashSet<LTC_COSTGROUPDTL>();
        }
    
        public int ID { get; set; }
        public string GROUPNO { get; set; }
        public string GROUPNAME { get; set; }
        public string GROUPTYPE { get; set; }
        public string ORGID { get; set; }
    
        public virtual ICollection<LTC_COSTGROUPDTL> LTC_COSTGROUPDTL { get; set; }
    }
}

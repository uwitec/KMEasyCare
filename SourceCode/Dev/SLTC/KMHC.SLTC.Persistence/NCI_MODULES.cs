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
    
    public partial class NCI_MODULES
    {
        public NCI_MODULES()
        {
            this.NCI_ROLE_MODULE = new HashSet<NCI_ROLE_MODULE>();
        }
    
        public string MODULEID { get; set; }
        public string MODULENAME { get; set; }
        public string URL { get; set; }
        public string DESCRIPTION { get; set; }
        public string SUPERMODULEID { get; set; }
        public string TARGET { get; set; }
        public string ICON { get; set; }
        public Nullable<int> ROOTORDER { get; set; }
        public Nullable<bool> ISSYS { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public string SYSTYPE { get; set; }
    
        public virtual ICollection<NCI_ROLE_MODULE> NCI_ROLE_MODULE { get; set; }
    }
}

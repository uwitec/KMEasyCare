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
    
    public partial class NCI_LOCATIONCODE
    {
        public NCI_LOCATIONCODE()
        {
            this.NCI_GOVERNMENT = new HashSet<NCI_GOVERNMENT>();
        }
    
        public int LOCATIONID { get; set; }
        public string LOCATIONNAME { get; set; }
        public Nullable<int> PARENTID { get; set; }
        public string FULLNAME { get; set; }
    
        public virtual ICollection<NCI_GOVERNMENT> NCI_GOVERNMENT { get; set; }
    }
}
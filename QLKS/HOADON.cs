//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.PHIEUDICHVUs = new HashSet<PHIEUDICHVU>();
        }
    
        public string MAHOADON { get; set; }
        public string MAPHIEUDANGKY { get; set; }
        public Nullable<System.DateTime> NGAYTHANHTOAN { get; set; }
        public Nullable<int> TONGTIEN { get; set; }
    
        public virtual PHIEUDANGKY PHIEUDANGKY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
    }
}

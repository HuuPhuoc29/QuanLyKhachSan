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
    
    public partial class PHIEUDANGKY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDANGKY()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string MAPHIEUDANGKY { get; set; }
        public string MAKHACHHANG { get; set; }
        public string MANHANVIEN { get; set; }
        public string MAPHONG { get; set; }
        public Nullable<System.DateTime> NGAYDANGKY { get; set; }
        public Nullable<System.DateTime> NGAYNHANPHONG { get; set; }
        public Nullable<System.DateTime> NGAYTRAPHONG { get; set; }
        public Nullable<int> TIENCOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom3_QuanLyResort_HQTCSDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhuongThucThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuongThucThanhToan()
        {
            this.DatPhong = new HashSet<DatPhong>();
            this.PhieuXacNhanDatPhong = new HashSet<PhieuXacNhanDatPhong>();
        }
    
        public short MaPhuongThuc { get; set; }
        public string TenPhuongThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatPhong> DatPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXacNhanDatPhong> PhieuXacNhanDatPhong { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }
    
        public string IDHoaDon { get; set; }
        public string IDNhanVien { get; set; }
        public System.DateTime NgayTaoHoaDon { get; set; }
        public string IDKhachHang { get; set; }
        public decimal ChietKhau { get; set; }
        public decimal TongTien { get; set; }
        public Nullable<decimal> LoiNhuan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
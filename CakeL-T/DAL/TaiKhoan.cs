//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public bool LoaiTK { get; set; }
        public bool TrangThai { get; set; }
        public string DiaChi { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string HinhAnh { get; set; }
        public bool TrangThaiXoa { get; set; }
    }
}

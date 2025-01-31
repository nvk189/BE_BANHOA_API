﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public  class SanPhamModel
    {
        public int MaSanPham { get; set; }
        public int MaChuyenMuc { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public string AnhDaiDien { get; set; }
        public decimal Gia { get; set; }
        public decimal GiaGiam { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public int LuotXem { get; set; }
        public bool DacBiet { get; set; }
        public List<ChiTietSanPhamModel> list_json_chitietsanpham { get; set; }

        public class ChiTietSanPhamModel
        {
            public int MaChiTietSanPham { get; set; }     
            public int MaSanPham { get; set; }        
            public string MoTaChiTiet { get; set; }
            public string ChiTiet { get; set; }
        }
    }

    public class SanPhamModel1
    {
        public int MaSanPham { get; set; }
        public int MaChuyenMuc { get; set; }
        public string TenSanPham { get; set; }
        public string AnhDaiDien { get; set; }
        public decimal Gia { get; set; }
        public decimal GiaGiam { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public int LuotXem { get; set; }
        public bool DacBiet { get; set; }
        public decimal DoanhThu { get; set; }
        public int SoLuongBan { get; set; }
    }

   

   
}

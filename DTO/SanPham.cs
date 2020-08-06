using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        string maSanPham;
        string tenSanPham;
        double giaBan;
        string tinhTrang;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public SanPham()
        {
        }
        public SanPham(string maSanPham, string tenSanPham, double giaBan, string tinhTrang)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.giaBan = giaBan;
            this.tinhTrang = tinhTrang;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { this.maNhanVien = value; }
        }

        private string tenNhanVien;
        public string TenNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private bool gioiTinh;
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private string queQuan;
        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private DateTime ngayVaoLam;
        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }

        public NhanVien()
        {

        }
        public NhanVien(string maNhanVien, string tenNhanVien, bool gioiTinh, string queQuan, DateTime ngaySinh)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
        }

        public NhanVien(string maNhanVien, string tenNhanVien, bool gioiTinh, string queQuan, DateTime ngaySinh, DateTime ngayVaoLam)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
        }
    }
}

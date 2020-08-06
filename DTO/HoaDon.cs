using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string maHoaDon;
        private double tongTien;
        private DateTime ngayTao;
        private bool daThanhToan;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public bool DaThanhToan { get => daThanhToan; set => daThanhToan = value; }

        public HoaDon()
        { }
        public HoaDon(string maHoaDon, double tongTien, DateTime ngayTao)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayTao = ngayTao;
            this.daThanhToan = false;
        }
        public HoaDon(string maHoaDon, double tongTien, DateTime ngayTao, bool daThanhToan)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayTao = ngayTao;
            this.daThanhToan = daThanhToan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        private string maBan;
        private int sucChua;
        private string tinhTrang;

        public string MaBan { get => maBan; set => maBan = value; }
        public int SucChua { get => sucChua; set => sucChua = value; }
        public string TinhTrang1 { get => tinhTrang; set => tinhTrang = value; }

        public Ban()
        {

        }
        public Ban(string maBan, int sucChua, string tinhTrang)
        {
            this.maBan = maBan;
            this.sucChua = sucChua;
            this.tinhTrang = tinhTrang;
        }
    }
}

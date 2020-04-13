using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class Nhaphang
    {
         public Nhaphang(string Idphieun, string Idhang, string Idncc, string Idlogin, string Tenhang, string Dvt, string Luongnhap, string Gianhap, DateTime Ngaynhap)
        {
            this.idphieun = Idphieun;
            this.idhang = Idhang;
            this.idncc = Idncc;
            this.idlogin = Idlogin;
            this.tenhang = Tenhang;
            this.dvt = Dvt;
            this.luongnhap = Luongnhap;
            this.gianhap = Gianhap;
            this.ngaynhap = Ngaynhap;
        }

        public Nhaphang(DataRow row)
        {
            this.idphieun = row["Idphieun"].ToString().Trim();
            this.idhang = row["Idhang"].ToString().Trim();
            this.idncc = row["Idncc"].ToString().Trim();
            this.idlogin = row["idLogin"].ToString().Trim();
            this.tenhang = row["Tenhang"].ToString().Trim();
            this.dvt = row["Dvt"].ToString().Trim();
            this.luongnhap = row["Luongnhap"].ToString().Trim();
            this.gianhap = row["Gianhap"].ToString().Trim();
            this.ngaynhap = Convert.ToDateTime(row["Ngaynhap"].ToString().Trim());

        }


        private string Idphieun;
        public string idphieun
        {
            get { return Idphieun; }
            set { Idphieun = value; }
        }

        private string Idhang;
        public string idhang
        {
            get { return Idhang; }
            set { Idhang = value; }
        }

        private string Idncc;
        public string idncc
        {
            get { return Idncc; }
            set { Idncc = value; }
        }
        private string idLogin;
        public string idlogin
        {
            get { return idLogin; }
            set { idLogin = value; }
        }


        private string Tenhang;
        public string tenhang
        {
            get { return Tenhang; }
            set { Tenhang = value; }
        }

        private string Dvt;
        public string dvt
        {
            get { return Dvt; }
            set { Dvt = value; }
        }

        private string Luongnhap;
        public string luongnhap
        {
            get { return Luongnhap; }
            set { Luongnhap = value; }
        }
        private string Gianhap;
        public string gianhap
        {
            get { return Gianhap; }
            set { Gianhap = value; }
        }

        private DateTime Ngaynhap;
        public DateTime ngaynhap
        {
            get { return Ngaynhap; }
            set { Ngaynhap = value; }
        }
     //   public DateTime ngaynhap { get; }


    }
}

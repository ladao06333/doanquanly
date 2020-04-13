using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class Xuathang
    {
         public Xuathang(string Idphieux, string Idhang, string Idkh, string Idlogin, string Tenhang, string Dvt, String Luongxuat, string Giaxuat, DateTime Ngayxuat)
        {
            this.idphieux = Idphieux;
            this.idhang = Idhang;
            this.idkh = Idkh;
            this.idlogin = Idlogin;
            this.tenhang = Tenhang;
            this.dvt = Dvt;
            this.luongxuat = Luongxuat;
            this.giaxuat = Giaxuat;
            this.ngayxuat = Ngayxuat;
        }

        public Xuathang(DataRow row)
        {
            this.idphieux = row["Idphieux"].ToString();
            this.idhang = row["Idhang"].ToString();
            this.idkh = row["Idkh"].ToString();
            this.idlogin = row["idLogin"].ToString();
            this.tenhang = row["Tenhang"].ToString();
            this.dvt = row["Dvt"].ToString();
            this.luongxuat = row["Luongxuat"].ToString();
            this.giaxuat = row["Giaxuat"].ToString();
            this.ngayxuat = Convert.ToDateTime(row["Ngayxuat"].ToString().Trim());

        }
        

        private string Idphieux;
        public string idphieux
        {
            get { return Idphieux; }
            set { Idphieux = value; }
        }

        private string Idhang;
        public string idhang
        {
            get { return Idhang; }
            set { Idhang = value; }
        }

        private string Idkh;
        public string idkh
        {
            get { return Idkh; }
            set { Idkh = value; }
        }

        private string Idlogin;
        public string idlogin
        {
            get { return Idlogin; }
            set { Idlogin = value; }
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

        private string Luongxuat;
        public string luongxuat
        {
            get { return Luongxuat; }
            set { Luongxuat = value; }
        }

        private string Giaxuat;
        public string giaxuat
        {
            get { return Giaxuat; }
            set { Giaxuat = value; }
        }

        private string ThanhTien;
        public string thanhtien
        {
            get { return ThanhTien; }
            set { ThanhTien = value; }
        }

        private DateTime Ngayxuat;
        public DateTime ngayxuat
        {
            get { return Ngayxuat; }
            set { Ngayxuat = value; }
        }
    }
}

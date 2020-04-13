using QuanLyKhoHang.DAO;
using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class fXuatHang : Form
    {
        public fXuatHang()
        {
            InitializeComponent();
            Load();
            Disable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Method

        List<Xuathang> SearchXuathangByName(string Tenhang)
        {
            List<Xuathang> xuathang = XuathangDAO.Instance.SearchXuathangByName(Tenhang);

            return xuathang;
        }

        void AddXuathangBinding()
        {
            txbIDxuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Idphieux"));
            txbIDhang.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Idhang"));
            txbIDlogin.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "idLogin"));
            txbIDkh.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Idkh"));
            txbTenHang.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Tenhang"));
            txbDvt.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Dvt"));
            txbLuongXuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Luongxuat"));
            txbGiaXuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Giaxuat"));
            dtNgayxuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Ngayxuat"));
        }
        private void Disable()
        {
            txbIDxuat.Enabled = false;
            txbIDhang.Enabled = false;
            txbIDlogin.Enabled = false;
            txbIDkh.Enabled = false;
        }


        void Load()
        {
            LoadListXuathang();
            AddXuathangBinding();
  
        }

        void LoadListXuathang()
        {
            dataxuat.DataSource = XuathangDAO.Instance.GetListXuathang();
            //dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
        }


        #endregion

        #region events


        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListXuathang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Idphieux = txbIDxuat.Text;
            string Idhang = txbIDhang.Text;
            string Tenhang = txbTenHang.Text;
            string Dvt = txbDvt.Text;
            string Luongxuat = txbLuongXuat.Text;
            string Giaxuat = txbGiaXuat.Text;
       


            if (XuathangDAO.Instance.InsertXuathang(Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Idphieux = txbIDxuat.Text;
            //string Idhang = txbIDhang.Text;
            //string Tenhang = txbTenHang.Text;
            //string Dvt = txbDvt.Text;
            //string Luongxuat = txbLuongXuat.Text;
            //string Giaxuat = txbGiaXuat.Text;
            //string ThanhTien = txbThanhTien.Text;


            if (XuathangDAO.Instance.DeleteXuathang(Idphieux))
            {
                MessageBox.Show("Xoá Hàng Hóa Thàng Công");
                LoadListXuathang();
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Hàng Hóa");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataxuat.DataSource = SearchXuathangByName(txbTim.Text);
        }

#endregion

        private void fXuatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThemPhieux_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class fNhapHang : Form
    {
        public fNhapHang()
        {
            InitializeComponent();
            Load();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Method

        List<Nhaphang> SearchNhaphangByName(string Tenhang)
        {
            List<Nhaphang> nhaphang = NhaphangDAO.Instance.SearchNhaphangByName(Tenhang);

            return nhaphang;
        }

        void AddNhaphangBinding()
        {
            txbIDnhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idphieun"));
            txbIDhang.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idhang"));
            txbNCC.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idncc"));
            txbNV.DataBindings.Add(new Binding("Text", datanhap.DataSource, "idLogin"));
            txbTenHang.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Tenhang"));
            txbDvt.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Dvt"));
            txbLuongNhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Luongnhap"));
            txbGiaNhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Gianhap"));
            dtNgaynhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Ngaynhap"));

        }

        private void Disable()
        {
            txbIDnhap.Enabled = false;
            btnLuuPhieun.Enabled = false;
        }
        void clear()
        {
            txbIDnhap.Clear();
            txbIDhang.Clear();
            txbNCC.Clear();
            txbTenHang.Clear();
            txbDvt.Clear();
            txbLuongNhap.Clear();
            txbGiaNhap.Clear();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txbIDnhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIDnhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbIDhang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIDhang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNCC.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNCC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbTenHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDvt.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDvt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbLuongNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbLuongNhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbGiaNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbGiaNhap.Focus();
                return false;
            }

            return true;

        }
        void Load()
        {
            LoadListNhaphang();
            AddNhaphangBinding();
            Disable();

        }

        void LoadListNhaphang()
        {
            datanhap.DataSource = NhaphangDAO.Instance.GetListNhaphang();
            //dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
        }


        #endregion


        #region events

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            txbIDnhap.Enabled = true;
            btnLuuPhieun.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Idphieun = txbIDnhap.Text;
            //string Idhang = txbIDhang.Text;
            //string Tenhang = txbTenHang.Text;
            //string Dvt = txbDvt.Text;
            //string Luongxuat = txbLuongXuat.Text;
            //string Giaxuat = txbGiaXuat.Text;
            //string ThanhTien = txbThanhTien.Text;


            if (NhaphangDAO.Instance.DeleteNhaphang(Idphieun))
            {
                MessageBox.Show("Xoá Phiếu Nhập Thàng Công");
                LoadListNhaphang();
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListNhaphang();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            datanhap.DataSource = SearchNhaphangByName(txbTim.Text);
        }

        #endregion


        private void btnInPhieun_Click(object sender, EventArgs e)
        {
            //       int Luongnhap = int.Parse(txbLuongNhap.Text);
            //      int Gianhap = int.Parse(txbGiaNhap.Text);
            //      DateTime Ngaynhap = dtNgaynhap.Value
               if (CheckData())
               {
                   string Idphieun = txbIDnhap.Text;
                   string Idhang = txbIDhang.Text;
                   string Idncc = txbNCC.Text;
                   string Idlogin = txbNV.Text;
                   string Tenhang = txbTenHang.Text;
                   string Dvt = txbDvt.Text;
                   string Luongnhap = txbLuongNhap.Text;
                   string Gianhap = txbGiaNhap.Text;
                   string Ngaynhap = dtNgaynhap.Text;
                   if (NhaphangDAO.Instance.InsertNhaphang(Idphieun, Idhang, Idncc, Idlogin, Tenhang, Dvt, Luongnhap, Gianhap, Ngaynhap))
                   {
                       MessageBox.Show("Thêm Thàng Công");
                       LoadListNhaphang();
                   }
                   else
                   {
                       MessageBox.Show("Có Lỗi Khi Thêm");
                   }
               }

        }

        private void datanhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txbIDnhap.Text = datanhap.Rows[index].Cells[0].Value.ToString();
                txbIDhang.Text=datanhap.Rows[index].Cells[1].Value.ToString();
                txbNCC.Text = datanhap.Rows[index].Cells[2].Value.ToString();
                txbNV.Text = datanhap.Rows[index].Cells[3].Value.ToString();
                txbTenHang.Text = datanhap.Rows[index].Cells[4].Value.ToString();
                txbDvt.Text = datanhap.Rows[index].Cells[5].Value.ToString();
                txbLuongNhap.Text = datanhap.Rows[index].Cells[6].Value.ToString();
                txbGiaNhap.Text = datanhap.Rows[index].Cells[7].Value.ToString();
                dtNgaynhap.Text = datanhap.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string Idphieun = txbIDnhap.Text;
                string Idhang = txbIDhang.Text;
                string Idncc = txbNCC.Text;
                string Idlogin = txbNV.Text;
                string Tenhang = txbTenHang.Text;
                string Dvt = txbDvt.Text;
                string Luongnhap = txbLuongNhap.Text;
                string Gianhap = txbGiaNhap.Text;
                string Ngaynhap = dtNgaynhap.Text;
                if (NhaphangDAO.Instance.UpdateNhapHang(Idphieun, Idhang, Idncc, Idlogin, Tenhang, Dvt, Luongnhap, Gianhap, Ngaynhap))
                {
                    MessageBox.Show("Sửa Thành Công");
                    LoadListNhaphang();
                }
                else
                {
                    MessageBox.Show("Có Lỗi Khi Thêm");
                }
            }
        }
    }
}

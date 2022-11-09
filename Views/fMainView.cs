using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanGaRan.Views
{
    public partial class fMainView : Form, IMainView
    {
        public fMainView()
        {
            InitializeComponent();
            btnKhachHang.Click += delegate { ShowKhachHangView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowChiNhanhView;
        public event EventHandler ShowNguyenLieuView;
        public event EventHandler ShowDanhMucView;
        public event EventHandler ShowMonAnView;
        public event EventHandler ShowHoaDonView;
        public event EventHandler ShowKhachHangView;
        public event EventHandler ShowNhanVienView;


        private void fMainView_Load(object sender, EventArgs e)
        {
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnChiNhanh.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKho.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.BorderSize = 0;
        }

        private void btnChiNhanh_MouseHover(object sender, EventArgs e)
        {
            btnChiNhanh.ForeColor = Color.Black;
            btnChiNhanh.FlatAppearance.BorderSize = 0;
        }

        private void btnChiNhanh_MouseLeave(object sender, EventArgs e)
        {
            btnChiNhanh.BackColor = Color.Transparent;
        }
        private void btnNhanVien_MouseHover(object sender, EventArgs e)
        {
            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.FlatAppearance.BorderSize = 0;
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = Color.Transparent;
        }
        private void btnKhachHang_MouseHover(object sender, EventArgs e)
        {
            btnKhachHang.ForeColor = Color.Black;
            btnKhachHang.FlatAppearance.BorderSize = 0;
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachHang.BackColor = Color.Transparent;
        }
        private void btnKho_MouseHover(object sender, EventArgs e)
        {
            btnKho.ForeColor = Color.Black;
            btnKho.FlatAppearance.BorderSize = 0;
        }

        private void btnKho_MouseLeave(object sender, EventArgs e)
        {
            btnKho.BackColor = Color.Transparent;
        }
        private void btnHoaDon_MouseHover(object sender, EventArgs e)
        {
            btnHoaDon.ForeColor = Color.Black;
            btnHoaDon.FlatAppearance.BorderSize = 0;
        }
        private void btnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            btnHoaDon.BackColor = Color.Transparent;
        }
        private void btnThongKe_MouseHover(object sender, EventArgs e)
        {
            btnThongKe.ForeColor = Color.Black;
            btnThongKe.FlatAppearance.BorderSize = 0;
        }
        private void btnThongKe_MouseLeave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.Transparent;
        }
    }
}
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

            btnKhachHang.FlatAppearance.BorderSize = 0;
        }
    }
}

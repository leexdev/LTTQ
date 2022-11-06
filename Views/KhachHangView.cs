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
    public partial class fKhachHangView : Form, IKhachHangView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public fKhachHangView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
        }

        private void AssociateAndRaiseViewEvent()
        {
            btnTimKiemKH.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnTimKiemKH.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }


        public string MaKH { get { return txbMaKH.Text; } set { txbMaKH.Text = value; } }
        public string TenKH { get { return txbTenKH.Text; } set { txbTenKH.Text = value; } }
        public DateTime NgaySinh { get { return dtpkNgaySinhKH.Value; } set { dtpkNgaySinhKH.Value = value; } }
        public string DiaChi { get { return txbDiaChiKH.Text; } set { txbDiaChiKH.Text = value; } }
        public string SDT { get { return txbSdtKH.Text; } set { txbSdtKH.Text = value; } }
        public string SearchValue { get { return txbTimKiemKH.Text; } set { txbTimKiemKH.Text = value; } }
        public bool IsEdit { get { return isEdit; } set { isEdit = value; } }
        public bool IsSuccessful { get { return isSuccessful; } set { isSuccessful = value; } }
        public string Message { get { return message; } set {message = value; } }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetKhachHangBindingSource(BindingSource khachHanglist)
        {
            dtgvKH.DataSource = khachHanglist;
        }

        private static fKhachHangView instance;
        public static fKhachHangView GetInstance()
        {
            if(instance == null || instance.IsDisposed)
                instance = new fKhachHangView();
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbNgayHienTai_Click(object sender, EventArgs e)
        {

        }

        private void KhachHangView_Load_1(object sender, EventArgs e)
        {
            lbNgayHienTai.Text = DateTime.Now.ToString();
            btnHome.FlatAppearance.BorderSize = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace QuanLyQuanGaRan.Models
{
    public class NhanVienModel
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private string cmnd;
        private string tenDangNhap;
        private string matKhau;
        private int quyen;

        [DisplayName("Mã nhân viên")]
        [Required(ErrorMessage = "Mã nhân viên không được để trống")]
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        [DisplayName("Tên nhân viên")]
        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên nhân viên nên đặt từ 3 đến 50 ký tự")]
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Địa chỉ nên đặt từ 3 đến 50 ký tự")]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        [DisplayName("CMND")]
        [Required(ErrorMessage = "CMND không được để trống")]
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên đăng nhập nên đặt từ 3 đến 50 ký tự")]
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mật khẩu nên đặt từ 3 đến 50 ký tự")]
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        [DisplayName("Quyền")]
        [Required(ErrorMessage = "Quyền không được để trống")]
        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
    }
}

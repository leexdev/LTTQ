using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuanLyQuanGaRan.Models
{
    public class KhachHangModel
    {
        private string maKH;
        private string tenKH;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;

        [DisplayName("Mã khách hàng")]
        [Required(ErrorMessage = "Mã khách hàng không được để trống")]
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        [DisplayName("Tên khách hàng")]
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên khách hàng nên đặt từ 3 đến 50 ký tự")]
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        [DisplayName("Địa chỉ")]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        [DisplayName("SĐT")]
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuanLyQuanGaRan.Models
{
    public class ChiNhanhModel
    {
        private string maCN;
        private string tenCN;
        private string diaChi;

        [DisplayName("Mã chi nhánh")]
        [Required(ErrorMessage = "Mã chi nhánh không được để trống")]
        public string MaCN
        {
            get { return maCN; }
            set { maCN = value; }
        }


        
        [DisplayName("Tên chi nhánh")]
        [Required(ErrorMessage = "Tên chi nhánh không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên chi nhánh nên đặt từ 3 đến 50 ký tự")]
        public string TenCN
        {
            get { return tenCN; }
            set { tenCN = value; }
        }

        [DisplayName("Địa chỉ chi nhánh")]
        [Required(ErrorMessage = "Địa chỉ chi nhánh không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Địa chỉ chi nhánh nên đặt từ 3 đến 50 ký tự")]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

    }
}

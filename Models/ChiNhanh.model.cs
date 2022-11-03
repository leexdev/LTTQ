using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuanLyQuanGaRan.Models
{
    public class ChiNhanh
    {
        private string maCN;
        private string tenCN;
        private string diaChi;

        [Required(ErrorMessage = "Thieu ma chi nhanh!!")]
        public string MaCN
        {
            get { return maCN; }
            set { maCN = value; }
        }

        public string TenCN
        {
            get { return tenCN; }
            set { tenCN = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanGaRan.Models
{
    interface INhanVienRepository
    {
        void Add(NhanVienModel nhanVienModel);
        void Edit(NhanVienModel nhanVienModel);
        void Delete(string maNV);
        IEnumerable<NhanVienModel> GetAll();
        IEnumerable<NhanVienModel> GetByValue();
    }
}

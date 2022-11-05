using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanGaRan.Models
{
    public interface IKhachHangRepository
    {
        void Add(KhachHangModel khachHangModel);
        void Edit(KhachHangModel khachHangModel);
        void Delete(string maKH);
        IEnumerable<KhachHangModel> GetAll();
        IEnumerable<KhachHangModel> GetByValue(string value);
    }
}

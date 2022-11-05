using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanGaRan.Models
{
    interface IChiNhanhRepository
    {
        void Add(ChiNhanhModel chiNhanhModel);
        void Edit(ChiNhanhModel chiNhanhModel);
        void Delete(string maCN);
        IEnumerable<ChiNhanhModel> GetAll();
        IEnumerable<ChiNhanhModel> GetByValue();

    }
}

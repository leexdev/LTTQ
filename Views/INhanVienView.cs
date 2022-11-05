using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanGaRan.Views
{
    public interface INhanVienView
    {
        string MaNV { get; set; }
        string TenNV { get; set; }
        DateTime NgaySinh { get; set; }
        string DiaChi { get; set; }
        string SDT { get; set; }
        string CMND { get; set; }
        string TenDangNhap { get; set; }
        string MatKhau { get; set; }
        int Quyen { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetNhanVienBindingSource(BindingSource nhanVienlist);
        void Show();
    }
}

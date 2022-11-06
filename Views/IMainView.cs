using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanGaRan.Views
{
    public interface IMainView
    {
        event EventHandler ShowChiNhanhView;
        event EventHandler ShowNguyenLieuView;
        event EventHandler ShowDanhMucView;
        event EventHandler ShowMonAnView;
        event EventHandler ShowHoaDonView;
        event EventHandler ShowKhachHangView;
        event EventHandler ShowNhanVienView;
    }
}

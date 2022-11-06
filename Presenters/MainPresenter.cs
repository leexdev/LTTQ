using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanGaRan.Views;
using QuanLyQuanGaRan.Models;
using QuanLyQuanGaRan._Repositories;

namespace QuanLyQuanGaRan.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowKhachHangView += ShowKhachHangView;
        }

        private void ShowKhachHangView(object? sender, EventArgs e)
        {
            IKhachHangView view = fKhachHangView.GetInstance();
            IKhachHangRepository repository = new KhachHangRepository(sqlConnectionString);
            new KhachHangPresenter(view, repository);
        }
    }
}

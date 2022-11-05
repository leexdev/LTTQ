using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanGaRan.Models;
using QuanLyQuanGaRan.Views;

namespace QuanLyQuanGaRan.Presenters
{
    public class KhachHangPresenter
    {
        private IKhachHangView view;
        private IKhachHangRepository repository;
        private BindingSource khachHangBindingSourse;
        private IEnumerable<KhachHangModel> khachHangList;

        public KhachHangPresenter(IKhachHangView view, IKhachHangRepository repository)
        {
            this.khachHangBindingSourse = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchKhachHang;
            this.view.AddNewEvent += AddNewKhachHang;
            this.view.EditEvent += LoadSelectedKhachHangToEdit;
            this.view.DeleteEvent += DeletedSelectedKhachHang;
            this.view.SaveEvent += SaveKhachHang;
            this.view.CancelEvent += CancelAction;

            this.view.SetKhachHangBindingSource(khachHangBindingSourse);

            LoadAllKhachHangList();

            this.view.Show();
        }

        private void LoadAllKhachHangList()
        {
            khachHangList = repository.GetAll();
            khachHangBindingSourse.DataSource = khachHangList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveKhachHang(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletedSelectedKhachHang(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedKhachHangToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewKhachHang(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchKhachHang(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                khachHangList = repository.GetByValue(this.view.SearchValue);
            else khachHangList = repository.GetAll();
            khachHangBindingSourse.DataSource = khachHangList;
        }
    }
}

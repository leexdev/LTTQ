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
            CleanviewFields();
        }

        private void SaveKhachHang(object? sender, EventArgs e)
        {
            var model = new KhachHangModel();
            model.MaKH = view.MaKH;
            model.TenKH = view.TenKH;
            model.NgaySinh = view.NgaySinh;
            model.DiaChi = view.DiaChi;
            model.SDT = view.SDT;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Sửa thành công";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Thêm thành công";
                }
                view.IsSuccessful = true;
                LoadAllKhachHangList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeletedSelectedKhachHang(object? sender, EventArgs e)
        {
            try
            {
                var khachhang = (KhachHangModel)khachHangBindingSourse.Current;
                repository.Delete(khachhang.MaKH);
                view.IsSuccessful = true;
                view.Message = "Xóa thành công!";
                LoadAllKhachHangList();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Không thể xóa!";
            }
        }

        private void LoadSelectedKhachHangToEdit(object? sender, EventArgs e)
        {
            var khachhang = (KhachHangModel)khachHangBindingSourse.Current;
            view.MaKH = khachhang.MaKH;
            view.TenKH = khachhang.TenKH;
            view.NgaySinh = khachhang.NgaySinh;
            view.DiaChi = khachhang.DiaChi;
            view.SDT = khachhang.SDT;
            view.IsEdit = true;
        }

        private void CleanviewFields()
        {
            view.MaKH = "";
            view.TenKH = "";
            view.NgaySinh = DateTime.Now;
            view.DiaChi = "";
            view.SDT = "";
        }

        private void AddNewKhachHang(object? sender, EventArgs e)
        {
            view.IsEdit = false;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanGaRan.Models;
using System.Data.SqlClient;

namespace QuanLyQuanGaRan._Repositories
{
    public class KhachHangRepository : BaseRepository, IKhachHangRepository
    {
        public KhachHangRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(KhachHangModel khachHangModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(string maKH)
        {
            throw new NotImplementedException();
        }

        public void Edit(KhachHangModel khachHangModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KhachHangModel> GetAll()
        {
            var khachHangList = new List<KhachHangModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM dbo.KhachHang ORDER BY MaKH";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var khachHangModel = new KhachHangModel();
                        khachHangModel.MaKH = reader[0].ToString();
                        khachHangModel.TenKH = reader[1].ToString();
                        khachHangModel.NgaySinh = DateTime.Parse(reader[2].ToString());
                        khachHangModel.DiaChi = reader[3].ToString();
                        khachHangModel.SDT = reader[4].ToString();
                        khachHangList.Add(khachHangModel);
                    }
                }
            }
            return khachHangList;
        }

        public IEnumerable<KhachHangModel> GetByValue(string value)
        {
            var khachHangList = new List<KhachHangModel>();
            string maKH = value;
            string tenKH = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM dbo.KhachHang where MaKH like + '%' + @maKH + '%' or TenKH like + '%' + @tenKH + '%' ORDER BY MaKH";
                command.Parameters.Add("@maKH", SqlDbType.NVarChar).Value = maKH;
                command.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = tenKH;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var khachHangModel = new KhachHangModel();
                        khachHangModel.MaKH = reader[0].ToString();
                        khachHangModel.TenKH = reader[1].ToString();
                        khachHangModel.NgaySinh = DateTime.Parse(reader[2].ToString());
                        khachHangModel.DiaChi = reader[3].ToString();
                        khachHangModel.SDT = reader[4].ToString();
                        khachHangList.Add(khachHangModel);
                    }
                }
            }
            return khachHangList;
        }
    }

}

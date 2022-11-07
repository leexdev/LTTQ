using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanGaRan.Models;
using QuanLyQuanGaRan.Presenters;
using QuanLyQuanGaRan._Repositories;
using QuanLyQuanGaRan.Views;

namespace QuanLyQuanGaRan
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = "Data Source=LEE;Initial Catalog=QuanLyBanGaRan;Integrated Security=True";
            IMainView view = new fMainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
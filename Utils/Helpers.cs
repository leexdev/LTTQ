using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuanLyQuanGaRan.Utils
{
    internal class Helpers
    {
        public string genUUID()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();
            return myuuidAsString;
        }
    }
}

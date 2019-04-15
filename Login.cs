using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    public static class Login
    {
        private static QuanLyHomestayEntities db;
        public static bool testLogin(string tk, string mk)
        {
            db = new QuanLyHomestayEntities();
            try
            {
                TAIKHOAN s = (from i in db.TAIKHOANs where i.TaiKhoan1 == tk && i.Matkhau == mk select i).FirstOrDefault();
                if(s!=null)
                {
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }
        
    }
}

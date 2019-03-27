using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    
    public static class Register
    {
        //private static QuanLyHomestayEntities db = new QuanLyHomestayEntities();
        public static TAIKHOAN tk;
        public static bool checkMK(string a,string b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            return false;
        }
        public static bool addNew(QuanLyHomestayEntities db, TAIKHOAN a)
        {
            db = new QuanLyHomestayEntities();
            if (a.HoTen == null) return false;
            if (a.Phone == null) return false;
            if (a != null)
            {
                    db.TAIKHOANs.Add(a);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public static bool checkTK(string a)
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN s = (from i in db.TAIKHOANs where i.TaiKhoan1.Equals(a) select i).FirstOrDefault();
            if (s != null) return true;
            return false;
        }
    }
}

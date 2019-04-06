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
        public static bool checkMK(string a, string b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
        public static bool addNew(QuanLyHomestayEntities db, TAIKHOAN a)
        {
            if (checkTK(a.TaiKhoan1)) return false;
            else if (a.HoTen == null || a.HoTen == "") return false;
            else if (a.Phone == null || a.Phone == "") return false;
            else if (a.Matkhau == null || a.Matkhau == "") return false;
            else if (a.TaiKhoan1 == null || a.TaiKhoan1 == "") return false;
            else if (a != null)
            {
                db.TAIKHOANs.Add(a);
                //db.SaveChanges();
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
        public static List<TAIKHOAN> LayDuLieu()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            return (from i in db.TAIKHOANs select i).ToList();
        }
    }
}

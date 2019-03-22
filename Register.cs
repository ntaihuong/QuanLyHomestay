using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    
    class Register
    {
        private QuanLyHomestayEntities db;
        TAIKHOAN tk;
        public bool checkMK(string a,string b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            return false;
        }
        public void addNew(TAIKHOAN a)
        {
            if (a != null)
            {
                db.TAIKHOANs.Add(a);
                db.SaveChanges();
            }
            else
                return;
        }
        public bool checkTK(string a)
        {
            TAIKHOAN s = (from i in db.TAIKHOANs where i.TaiKhoan1.Equals(a) select i).FirstOrDefault();
            if (s != null) return true;
            return false;
        }
    }
}

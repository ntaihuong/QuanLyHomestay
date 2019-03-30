using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    public static class DatPhong
    {
        public static bool addnewHoaDon(QuanLyHomestayEntities db,HOADON hd)
        {
            if (hd.NgayDen == null) return false;
            else if(hd.NgayDi == null) return false;
            else
            {
                db.HOADONs.Add(hd);
                db.SaveChanges();
                return true;
            }        
        }
    }
}

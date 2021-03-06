﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    public static class DatPhong
    {
        public static bool addnewHoaDon(QuanLyHomestayEntities db, HOADON hd)
        {
            if (hd.NgayDen == null) return false;
            else if (hd.NgayDen < DateTime.Today) return false;
            else if (hd.NgayDen > hd.NgayDi) return false;
            else if (hd.NgayDi == null) return false;
            else if (hd.MaLoaiPhong == null) return false;
            else if (hd.MaHoaDon == null) return false;
            else
            {
                db.HOADONs.Add(hd);
                db.SaveChanges();
                return true;
            }


        }
        public static bool deletePhong(QuanLyHomestayEntities db, HOADON hd)
        {
            db = new QuanLyHomestayEntities();
           
            db.HOADONs.Attach(hd);
            db.HOADONs.Remove(hd);
            db.SaveChanges();
            return true;
        }
    }
}

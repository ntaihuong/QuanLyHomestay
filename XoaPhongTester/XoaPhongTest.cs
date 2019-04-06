using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;
using System.Linq;

namespace XoaPhongTester
{
    [TestClass]
    public class XoaPhongTest
    {
        [TestMethod]
        public void TestXoaDayDuThongTin()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC7";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = true;
            bool actual = DatPhong.deletePhong(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXoaCoMoiMaHoaDon()
        {
            string MaHoaDon = "E72G4TC5";
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = (from i in db.HOADONs where i.MaHoaDon.Equals(MaHoaDon) select i).FirstOrDefault();  

            bool expected = true;
            bool actual = DatPhong.deletePhong(db, hd);

            Assert.AreEqual(expected, actual);
        }
    }
}

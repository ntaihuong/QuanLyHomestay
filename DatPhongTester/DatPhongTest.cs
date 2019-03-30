using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;

namespace DatPhongTester
{
    [TestClass]
    public class DatPhongTest
    {
        [TestMethod]
        public void TestDatPhongDD()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND" ;
            hd.SoTienDatTruoc = 50000;
            hd.MaHoaDon = "E72G4TC5";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = true;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongCoc()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC5";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = true;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

    }
}

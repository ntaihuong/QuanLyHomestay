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
            hd.MaHoaDon = "E72G4TC7";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = true;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongNgayDen()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = null;
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC7";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongNgayDi()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = null;
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC6";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongNgayDiBeHonNgayDen()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/25/2019");
            hd.NgayDi = DateTime.Parse("5/20/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC8";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongMaLoaiPhong()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = null;
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC8";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongGia_DonVi()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = null;
            hd.DonVi = null;
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC6";
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = true;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongMaHoaDon()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = "NC1";
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = null;
            hd.NgayThanhToan = DateTime.Parse("5/20/2019");

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDatPhongKhongNgayTT()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            HOADON hd = new HOADON();
            hd.NgayDen = DateTime.Parse("5/20/2019");
            hd.NgayDi = DateTime.Parse("5/25/2019");
            hd.MaLoaiPhong = null;
            hd.GiaTien = "299000";
            hd.DonVi = "VND";
            hd.SoTienDatTruoc = null;
            hd.MaHoaDon = "E72G4TC7";
            hd.NgayThanhToan = null;

            bool expected = false;
            bool actual = DatPhong.addnewHoaDon(db, hd);

            Assert.AreEqual(expected, actual);
        }
    }
}

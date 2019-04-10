using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;

namespace DangKyTester
{
    [TestClass]
    public class DangKyTest
    {
        [TestMethod]
        public void TestDangKyDayDuMKMin()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Tùng";
            tk.Email = "tung@gmail.com";
            tk.Phone = "0956557102";
            tk.TaiKhoan1 = "tung123";
            tk.Matkhau = "12345678";

            bool expected = true;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyDayDuMKMax()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Vũ Thanh Hưng";
            tk.Email = "thanhhung@gmail.com";
            tk.Phone = "0956557105";
            tk.TaiKhoan1 = "thanhhung";
            tk.Matkhau = "123456789101112";

            bool expected = true;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyKhongEmail()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Hùng";
            tk.Email = null;
            tk.Phone = "0956557103";
            tk.TaiKhoan1 = "hung123";
            tk.Matkhau = "12345709";

            bool expected = true;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyHotenNull()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = null;
            tk.Email = null;
            tk.Phone = "0956557104";
            tk.TaiKhoan1 = "hung11";
            tk.Matkhau = "12357809";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyPhoneNull()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thị An";
            tk.Email = null;
            tk.Phone = null;
            tk.TaiKhoan1 = "thian11";
            tk.Matkhau = "12385123";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyTKNull()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Bình";
            tk.Email = null;
            tk.Phone = "0956557108";
            tk.TaiKhoan1 = null;
            tk.Matkhau = "12354567";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyMKNull()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thị Bình";
            tk.Email = null;
            tk.Phone = "0956557111";
            tk.TaiKhoan1 = "binh@";
            tk.Matkhau = null;

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyMKQuaNgan()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Bình";
            tk.Email = null;
            tk.Phone = "0956557108";
            tk.TaiKhoan1 = "thanhbinh123";
            tk.Matkhau = "1235456";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyMKQuaDai()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Bình";
            tk.Email = null;
            tk.Phone = "0956557108";
            tk.TaiKhoan1 = "thanhbinh12";
            tk.Matkhau = "123456789123456789";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDangKyTrungTaiKhoan()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Văn A";
            tk.Email = "VanA@gmail.com";
            tk.Phone = "0909123456";
            tk.TaiKhoan1 = "yeupanhmaj";
            tk.Matkhau = "789789789";

            bool expected = false;
            bool actual = Register.addNew(db, tk);

            Assert.AreEqual(expected, actual);
        }
    }
}

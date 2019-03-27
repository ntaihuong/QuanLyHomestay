using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;

namespace DangKyTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDangKyDayDu()
        {
            QuanLyHomestayEntities db = new QuanLyHomestayEntities() ;
            TAIKHOAN tk = new TAIKHOAN();
            tk.HoTen = "Nguyễn Thanh Tùng";
            tk.Email = "tung@gmail.com";
            tk.Phone = "0956557102";
            tk.TaiKhoan1 = "tung123";
            tk.Matkhau = "123456";
           

            bool expected = true;
            bool actual = Register.addNew(db,tk);

            Assert.AreEqual(expected, actual);
        }

       
    }
}

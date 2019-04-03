using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;
using System.Collections.Generic;

namespace DangKyTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLayDuLieu()
        {
            List<TAIKHOAN> taikhoan = new List<TAIKHOAN>();
            bool expected = true;
            bool actual = new bool();
            taikhoan = Register.LayDuLieu();
            if (taikhoan.Count > 0) actual = true;
            Assert.AreEqual(expected, actual);
        }
    }
}

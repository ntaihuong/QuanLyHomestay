using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomestayApp;

namespace DangNhapTester
{
    [TestClass]
    public class DangNhapTest
    {
        [TestMethod]
        public void TestLoginDayDu()
        {
            string tk = "yeupanhmaj";
            string mk = "123123123";
            bool expected = true;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginSaiPass()
        {
            string tk = "yeupanhmaj";
            string mk = "1231231234";
            bool expected = false;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginKhongPass()
        {
            string tk = "yeupanhmaj";
            string mk = null;
            bool expected = false;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginSaiUser()
        {
            string tk = "yeupanhmai";
            string mk = "123123123";
            bool expected = false;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginKhongUser()
        {
            string tk = null;
            string mk = "123123123";
            bool expected = false;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginBoTrongCa2()
        {
            string tk = null;
            string mk = null;
            bool expected = false;
            bool actual = Login.testLogin(tk, mk);

            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForTask1
{
    [TestClass]
    public class GenerateQRStringTest
    {
        [TestMethod]
        public void Generate_new_St_First()
        {
            string actual = "", expected = "ИЭТХ;24.04.2020;77";

            actual = Task1.GenerateQRString.FirstGenerate("ОИЭТХФ", new DateTime(2020,4,24), "42867734");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Generate_new_St_First_With_error()
        {
            string actual = "", expected = "";

            actual = Task1.GenerateQRString.FirstGenerate("", new DateTime(2020, 4, 24), "42867734");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Generate_new_St_First_With_error2()
        {
            string actual = "", expected = "";

            actual = Task1.GenerateQRString.FirstGenerate("dfd", new DateTime(2020, 4, 24), "");

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Generate_new_St_Second()
        {
            string actual = "", expected = "ОИЭТХФ-42867734";

            actual = Task1.GenerateQRString.SecondGenerate("ОИЭТХФ", new DateTime(2020, 4, 24), "42867734");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Generate_new_St_Second_With_error()
        {
            string actual = "", expected = "";

            actual = Task1.GenerateQRString.SecondGenerate("", new DateTime(2020, 4, 24), "42867734");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Generate_new_St_Second_With_error2()
        {
            string actual = "", expected = "";

            actual = Task1.GenerateQRString.SecondGenerate("dfd", new DateTime(2020, 4, 24), "");

            Assert.AreEqual(expected, actual);
        }
    }
}

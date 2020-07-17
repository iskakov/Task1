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
        public void Get_Object_From_St_First()
        {
            string actualName = "", expectedName = "ИЭТХ";
            string actualPerAcc = "", expectedPerAcc = "77";
            string actualDate = "", expectDate= "24.04.2020";

            DateTime dateTime;
            Task1.GenerateQRString.FirstGetObject("ИЭТХ;24.04.2020;77", out actualName, out dateTime, out actualPerAcc);
            actualDate = dateTime.ToShortDateString();
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
            Assert.AreEqual(expectDate, actualDate);

        }
        [TestMethod]
        public void Get_Object_From_St_First_Error1()
        {
            string actualName = "", expectedName = "";
            string actualPerAcc = "", expectedPerAcc = "";
            string actualDate = "", expectDate = "";

            DateTime dateTime;
            Task1.GenerateQRString.FirstGetObject("", out actualName, out dateTime, out actualPerAcc);
            if(!dateTime.Equals(new DateTime()))
                actualDate = dateTime.ToShortDateString();
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
            Assert.AreEqual(expectDate, actualDate);
        }
      
        [TestMethod]
        public void Get_Object_From_St_First_Error2()
        {

            string actualName = "", expectedName = "";
            string actualPerAcc = "", expectedPerAcc = "";
            string actualDate = "", expectDate = "";
            DateTime dateTime;
            Task1.GenerateQRString.FirstGetObject("ИЭТХ-24.04.2020-77", out actualName, out dateTime, out actualPerAcc);
            if (!dateTime.Equals(new DateTime()))
                actualDate = dateTime.ToShortDateString();
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
            Assert.AreEqual(expectDate, actualDate);
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

        [TestMethod]
        public void Get_Object_From_St_Second()
        {
            string actualName = "", expectedName = "ОИЭТХФ";
            string actualPerAcc = "", expectedPerAcc = "42867734";
            Task1.GenerateQRString.SecondGetObject("ОИЭТХФ-42867734", out actualName, out actualPerAcc);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
        }
        [TestMethod]
        public void Get_Object_From_St_Second_Error1()
        {
            string actualName = "", expectedName = "";
            string actualPerAcc = "", expectedPerAcc = "";
            Task1.GenerateQRString.SecondGetObject("", out actualName, out actualPerAcc);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
        }

        [TestMethod]
        public void Get_Object_From_St_Second_Error2()
        {
            string actualName = "", expectedName = "";
            string actualPerAcc = "", expectedPerAcc = "";
            Task1.GenerateQRString.SecondGetObject("ОИЭТХФ:42867734", out actualName, out actualPerAcc);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPerAcc, actualPerAcc);
        }
    }

   
}

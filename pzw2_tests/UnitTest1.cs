using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testing_pzw2;

namespace pzw2_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultConstructorCheck()
        {
            Date a = new Date();
            Assert.AreEqual(0,a.day,"Wrong day in default contructor!");            
        }

        [TestMethod]
        public void SetConstructorCheck()
        {
            Date a = new Date(29,3,2015);
            Assert.AreEqual(3, a.month, "Wrong month in set constructor!");
        }

        [TestMethod]
        public void isLeapYearFalseCheck()
        {
            Date a = new Date(22, 3, 2015);
            Boolean flag = a.isLeapYear();
            Assert.AreEqual(false, flag, "Error in leap year check! Should be false!");
        }

        [TestMethod]
        public void isLeapYearTrueCheck()
        {
            Date a = new Date(22, 3, 2016);
            Boolean flag = a.isLeapYear();
            Assert.AreEqual(true, flag, "Error in leap year check! Should be true!");
        }

        [TestMethod]
        public void isLeapYearTrue400sCheck()
        {
            Date a = new Date(22, 3, 2000);
            Boolean flag = a.isLeapYear();
            Assert.AreEqual(true, flag, "Error in leap year check! Should be true!");
        }

        [TestMethod]
        public void isLeapYearTrue100sCheck()
        {
            Date a = new Date(22, 3, 2100);
            Boolean flag = a.isLeapYear();
            Assert.AreEqual(false, flag, "Error in leap year check! Should be false!");
        }

        [TestMethod]
        public void getNumberOfDays31()
        {
            Date a = new Date(22, 3, 2001);
            int exp = 31 - 22;
            Assert.AreEqual(exp, a.getNumberOfRemaingDaysInMonth(), "Error, miscalculation!");
        }

        [TestMethod]
        public void getNumberOfDays30()
        {
            Date a = new Date(22, 4, 2001);
            int exp = 30 - 22;
            Assert.AreEqual(exp, a.getNumberOfRemaingDaysInMonth(), "Error, miscalculation!");
        }

        [TestMethod]
        public void getNumberOfDaysFebrNotLeap()
        {
            Date a = new Date(22, 2, 2001);
            int exp = 28 - 22;
            Assert.AreEqual(exp, a.getNumberOfRemaingDaysInMonth(), "Error, miscalculation!");
        }

        [TestMethod]
        public void getNumberOfDaysFebrIsLeap()
        {
            Date a = new Date(22, 2, 2004);
            int exp = 29 - 22;
            Assert.AreEqual(exp, a.getNumberOfRemaingDaysInMonth(), "Error, miscalculation!");
        }

        [TestMethod]
        public void getNumberOfDaysFebrNone()
        {
            Date a = new Date(22, 14, 2004);
            int exp = -1;
            Assert.AreEqual(exp, a.getNumberOfRemaingDaysInMonth(), "Error, miscalculation!");
        }

        [TestMethod]
        public void getMonthNameTest()
        {
            Date a = new Date(26, 6, 1994);
            string exp = "Lipanj";
            Assert.AreEqual(exp, a.getMonthName(), "Wrong month name!");
        }

        [TestMethod]
        public void getMonthNameTestNone()
        {
            Date a = new Date();
            string exp = "";
            Assert.AreEqual(exp, a.getMonthName(), "Wrong month name!");
        }
    }
}

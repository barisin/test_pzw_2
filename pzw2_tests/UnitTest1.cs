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


    }
}

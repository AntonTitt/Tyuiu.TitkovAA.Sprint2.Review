using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint2.Review.V6.Lib;
namespace Tyuiu.TitkovAA.Sprint2.Review.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(true, dt.CheckDotInShadedArea(1.3, 1));

        }
    }
}

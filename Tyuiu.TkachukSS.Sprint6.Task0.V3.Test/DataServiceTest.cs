using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint6.Task0.V3.Lib;
namespace Tyuiu.TkachukSS.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(3);
            double wait = result;
            Assert.AreEqual(wait, result);
        }
    }
}

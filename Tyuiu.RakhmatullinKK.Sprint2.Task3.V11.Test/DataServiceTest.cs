using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint2.Task3.V11.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 6;
            double res = ds.Calculate(x);
            double wait = 6.11;
            Assert.AreEqual(wait, res);
        }
    }
}
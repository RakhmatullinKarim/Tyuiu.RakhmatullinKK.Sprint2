using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint2.Task0.V27.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

            public void TestLogicalSequence()
            {
                DataService ds = new DataService();
                int x = 1305;
                int y = 275;

                bool[] expected = { true, false, true, false, false, true };
                bool[] result = ds.CalculateLogicalSequence(x, y);

                CollectionAssert.AreEqual(expected, result);
            }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint4.Task4.V1.Lib;

namespace Tyuiu.HubulovaVI.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { 2, 5, 1, 7, 5 },
                { 4, 4, 7, 4, 4 },
                { 7, 1, 6, 8, 8 },
                { 8, 1, 5, 8, 4 },
                { 8, 9, 1, 7, 3 } };

            Assert.AreEqual(68, ds.Calculate(array));
        }
    }
}
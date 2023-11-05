using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint4.Task2.V14.Lib;

namespace Tyuiu.HubulovaVI.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 3, 5, 4, 6, 7, 8, 1, 3, 1, 5, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 11025;
            Assert.AreEqual(wait, res);
        }
    }
}
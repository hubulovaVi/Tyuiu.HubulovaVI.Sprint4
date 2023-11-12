using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint4.Task7.V5.Lib;

namespace Tyuiu.HubulovaVI.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check777()
        {
            int n = 3;
            int m = 3;
            int[,] mas = new int[n, m];
            string str = "246813579";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
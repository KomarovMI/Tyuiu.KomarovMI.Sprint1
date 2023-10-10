using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 2;
            double x2 = 6;
            double y2 = 2;
            double x3 = 2;
            double y3 = 4;
            double wait = 5;
            var res = ds.TriangleArea(x1, y1, x2, y2,x3, y3);
            Assert.AreEqual(wait, res);
        }
    }
}

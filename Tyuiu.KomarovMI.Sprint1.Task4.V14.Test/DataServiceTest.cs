﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint1.Task4.V14.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double wait = 0.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

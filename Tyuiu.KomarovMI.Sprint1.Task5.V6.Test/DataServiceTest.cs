using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            int k = 7;
            DataService ds = new DataService();
            double res = ds.Calculate(k);
            int result = Convert.ToInt32(res);
            int wait = 0;
            Assert.AreEqual(wait, result);


        }
    }
}

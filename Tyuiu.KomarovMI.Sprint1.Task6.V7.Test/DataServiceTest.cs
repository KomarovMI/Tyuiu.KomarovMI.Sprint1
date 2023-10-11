using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint1.Task6.V7.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Максимы";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "Максим";
            Assert.AreEqual(wait, res);

        }
    }
}

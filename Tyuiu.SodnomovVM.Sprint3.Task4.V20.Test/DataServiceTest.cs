using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SodnomovVM.Sprint3.Task4.V20.Lib;

namespace Tyuiu.SodnomovVM.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int StartValue = -3;
            int StopValue = 3;
            double proverka = ds.Calculate(StartValue, StopValue);
            Assert.AreEqual(proverka, 10.341);
        }
    }
}

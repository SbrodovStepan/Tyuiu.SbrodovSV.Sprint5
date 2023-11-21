using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SbrodovSV.Sprint5.Task6.V6.Lib;

namespace Tyuiu.SbrodovSV.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V6.txt";
            int res = dataService.LoadFromDataFile(path), wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}

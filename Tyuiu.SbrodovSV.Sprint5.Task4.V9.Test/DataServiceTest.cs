using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SbrodovSV.Sprint5.Task4.V9.Lib;

namespace Tyuiu.SbrodovSV.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}

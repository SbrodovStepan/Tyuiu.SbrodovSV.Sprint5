using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SbrodovSV.Sprint5.Task2.V14.Lib;

namespace Tyuiu.SbrodovSV.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project's C#\Tyuiu.SbrodovSV.Sprint5\Tyuiu.SbrodovSV.Sprint5.Task2.V14\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}

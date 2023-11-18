using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SbrodovSV.Sprint5.Task3.V5.Lib;

namespace Tyuiu.SbrodovSV.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project's C#\Tyuiu.SbrodovSV.Sprint5\Tyuiu.SbrodovSV.Sprint5.Task3.V5\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}

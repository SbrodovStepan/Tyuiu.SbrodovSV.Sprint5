using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SbrodovSV.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double maxNum = double.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 10 == 0 && Convert.ToDouble(line) > maxNum)
                    {
                        maxNum = Convert.ToDouble(line);
                    }
                }
            }
            return maxNum;
        }
    }
}

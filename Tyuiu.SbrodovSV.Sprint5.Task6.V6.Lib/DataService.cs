using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SbrodovSV.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {

        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c >= 'а' && c <= 'я')
                        {
                            count += 1;
                        }
                    }
                }
            }
            return count;

            //int count = 0;
            //Regex regex = new Regex("[а-я]");
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        MatchCollection matches = regex.Matches(line);
            //        foreach (Match match in matches)
            //        {
            //            count += 1;
            //        }
            //    }
            //}
            //return count;
        }
    }
}

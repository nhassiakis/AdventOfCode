using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1_2021.Data
{
    public class DataList
    {
        List<int> measurmentList = new List<int>();

        public List<int> ReadFileToList()
        {
            string pathLocal = Directory.GetCurrentDirectory();
            var lines = File.ReadAllLines(pathLocal+ "\\..\\..\\..\\Data\\measurmentData.txt");
            foreach (var line in lines)
            {
                measurmentList.Add(Convert.ToInt32(line));
            }
            return measurmentList;
        }

        public void PartTwoAoC()
        {

        }

    }

}

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

        public List<int> SomeMethod()
        {
            string path = "C:\\Users\\Nico\\Documents\\Github\\AdventOfCode\\2021\\Day1\\AdventOfCodeDay1\\AdventOfCodeDay1_2021\\Data\\measurmentData.txt";
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                measurmentList.Add(Convert.ToInt32(line));
            }
            return measurmentList;
        }


    }

}

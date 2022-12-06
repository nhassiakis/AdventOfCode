using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Datalayer
    {
        public List<string> Data { get; set; }




        public string[] ReadData()
        {
            string[] lines = System.IO.File.ReadAllLines(@"../../../../Part2Data.txt");

            return lines;
        }
    }
}

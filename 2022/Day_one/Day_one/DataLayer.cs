using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_one
{
    internal class DataLayer
    {
        public List<string> Data { get; set; }
     
        
        
        
        public string[] ReadData()
        {
            string[] lines = System.IO.File.ReadAllLines(@"../../../../PartOneData.txt");

            return lines;
        }
    }

}

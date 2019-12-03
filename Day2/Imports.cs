using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;


namespace Day2
{
    public static class Imports
    {
        public static List<int> ImportCsv()
        {
            List<int> allValues = new List<int>();
            using (StreamReader reader = new StreamReader(@"C:\Users\Nico\source\repos\AdventOfCode\Day2\Data\data.csv"))
            {
                string line = null;
                while (null != (line = reader.ReadLine()))
                {
                    string[] values = line.Split(',');
                    //int[] numbers = new int[values.Length - 1];
                    for (int i = 0; i < values.Length; i++)
                        allValues.Add(Int32.Parse(values[i]));

                }
            }
            return allValues;
        }
    }
}

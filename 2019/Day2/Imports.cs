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
            string pathLaptop = @"C:\Users\Nico\Documents\GitHub\AdventOfCode\Day2\Data\data.csv";
            List<int> allValues = new List<int>();
            using (StreamReader reader = new StreamReader(pathLaptop))
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

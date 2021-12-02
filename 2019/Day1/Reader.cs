using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Day1
{
    public class Reader
    {
        public Reader()
        {

        }

        public static List<int> ReadFile()
        {
            string path = @"C:\Users\Nico\source\repos\AdventOfCode\Day1\Data\TextFile1.txt";
            List<int> fuel = new List<int>();
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    int intLine = Convert.ToInt32(line);
                    fuel.Add(intLine);   // Add to list.
                }


                return fuel;
            }
        }
    }

}

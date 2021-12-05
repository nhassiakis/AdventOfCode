using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AdventOfCodeDay1_2021.Data;

namespace AdventOfCodeDay1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int incriments = 0;
            DataList list = new DataList();
            List<int> someData = list.SomeMethod();
            List<int> newData = new List<int>();
            foreach (var currentData in someData)
            {
                if (newData.Count > 0)
                {
                    int highestNumber = newData.Max(t => t);
                    if (currentData > highestNumber)
                    {
                        incriments++;
                    }
                }
                newData.Add(currentData);
            }

            Console.WriteLine("measurements larger than the previous measurement: " + incriments);
        }
    }
}

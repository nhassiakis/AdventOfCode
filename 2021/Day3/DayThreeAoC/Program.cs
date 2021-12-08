using System;
using DayThreeAoC.Data;

namespace DayThreeAoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32("10110", 2).ToString());
            DataReader.ProcessBinary();
        }
    }
}

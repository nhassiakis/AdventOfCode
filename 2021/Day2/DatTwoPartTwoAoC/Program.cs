using System;
using System.IO;
using System.Linq;
using System.Collections;
using DayTwoAoC.Data;

namespace DatTwoPartTwoAoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Submarine position");
            int depth = 0;
            int horizontalPos = 0;
            
            DataList dataStuff = new DataList();
            var calculatedPath = dataStuff.GetCalculateHorizontalAndDepth(horizontalPos, depth);
            Console.WriteLine(calculatedPath);

        }
    }
}

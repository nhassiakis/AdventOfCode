using System;
using System.IO;
using System.Linq;
using System.Collections;
using DayTwoAoC.Data;
namespace DayTwoAoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Submarine position");
            int depth = 0;
            int horizontalPos = 0;
            DataList dataStuff = new DataList();
            var totalHorizontalPos = dataStuff.GetHorizontal(horizontalPos);
            var totalDepth = dataStuff.GetDepth(depth);

            Console.WriteLine("Total horizontal position: " + totalHorizontalPos + "\n Total Depth: " + totalDepth + "\n Horizontal*Depth: " + totalHorizontalPos*totalDepth);
        }

    }
}
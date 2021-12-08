using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeAoC.Data
{
    class DataReader
    {
        public static void ProcessBinary()
        {
            //var path = "C:\\Users\\Nico\\Documents\\Github\\AdventOfCode\\2021\\Day3\\DayThreeAoC\\Data\\DataInput.txt";
            //List<string> binaryList = File.ReadAllLines(path).ToList();
            string pathLocal = Directory.GetCurrentDirectory();
            var binaryList = File.ReadAllLines(pathLocal + "\\..\\..\\..\\Data\\measurmentData.txt");
            var numOfZero = 0;
            var numOfOnes = 0;
            for (int i = 0; i < binaryList.Length; i++)
            {
                var binaryString = binaryList[i];
                for (int y = 0; y < binaryString.Length; y++)
                {
                    var binary = binaryString[y];
                    if (binaryList.Equals("0"))
                    {
                        numOfZero++;
                    }
                    else if (binary.Equals("1"))
                    {
                        numOfOnes++;
                    }
                }
            }
            if (numOfZero > numOfOnes)
            {
                Console.WriteLine("First number is: zero" + numOfZero + "    " + numOfOnes);
            }
            else
            {
                Console.WriteLine("First number is: One" + numOfZero + "    " + numOfOnes);
            }
        }
    }
}
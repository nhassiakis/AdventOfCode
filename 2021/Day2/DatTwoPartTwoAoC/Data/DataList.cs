using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DayTwoAoC.Data
{
    public class DataList
    {
        public int aimPos = 0;
        public int GetCalculateHorizontalAndDepth(int horizontalPos, int depth)
        {
            string path = "C:\\Users\\Nico\\Documents\\Github\\AdventOfCode\\2021\\Day2\\DatTwoPartTwoAoC\\Data\\DataFile.txt";
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                if (Regex.IsMatch(line, "forward \\d+"))
                {
                    int lineForward = Convert.ToInt32(Regex.Replace(line, "forward ", ""));
                    horizontalPos += lineForward;
                    if (aimPos != 0)
                    {
                        depth += lineForward*aimPos;
                    }
                }

                else if (Regex.IsMatch(line, "down \\d+"))
                {
                    int lineDepth = Convert.ToInt32(Regex.Replace(line, "down ", ""));
                    aimPos += lineDepth;

                }

                else if (Regex.IsMatch(line, "up \\d+"))
                {
                    int lineDepth = Convert.ToInt32(Regex.Replace(line, "up ", ""));
                    aimPos -= lineDepth;
                }
            }

            //return horizontalPos;
            Console.WriteLine("DEPTH: " + depth);
            Console.WriteLine("Horizontal Position: " + horizontalPos);
            var depthMulitpliedByHorPos = horizontalPos * depth;
            return depthMulitpliedByHorPos;

        }
    }
}

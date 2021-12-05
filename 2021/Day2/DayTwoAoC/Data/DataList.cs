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
        List<int> depthList = new List<int>();
        List<string> horizontalList = new List<string>();

        public int GetHorizontal(int horizontalPos)
        {
            string path = "C:\\Users\\Nico\\Documents\\Github\\AdventOfCode\\2021\\DayTwoAoC\\Data\\DataFile.txt";
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                if (Regex.IsMatch(line, "forward \\d+"))
                {
                    int lineDepth = Convert.ToInt32(Regex.Replace(line, "forward ", ""));
                    horizontalPos += lineDepth;
                }
            }
            return horizontalPos;
        }
        public int GetDepth(int depth)
        {
            string path = "C:\\\\Users\\Nico\\Documents\\Github\\AdventOfCode\\2021\\DayTwoAoC\\Data\\DataFile.txt";
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (Regex.IsMatch(line, "down \\d+"))
                {
                    int lineDepth = Convert.ToInt32(Regex.Replace(line, "down ", ""));
                    depth += lineDepth;
                    //depthList.Add(Convert.ToInt32(line));
                }
                if (Regex.IsMatch(line, "up \\d+"))
                {
                    int lineDepth = Convert.ToInt32(Regex.Replace(line, "up ", ""));
                    depth -= lineDepth;
                }
            }
            return depth;
        }
    }
}

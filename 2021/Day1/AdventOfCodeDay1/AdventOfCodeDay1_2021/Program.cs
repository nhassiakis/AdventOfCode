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
            List<int> depthDataList = list.ReadFileToList();
            List<int> newData = new List<int>();
            //         <-------------------------------------------->

            //Part one

            //foreach (var currentData in depthDataList)
            //{
            //    if (newData.Count > 0)
            //    {
            //        int lastNumber = newData.Last();
            //        if (currentData > lastNumber)
            //        {
            //            incriments++;
            //        }
            //    }
            //    newData.Add(currentData);
            //}
            //Console.WriteLine("measurements larger than the previous measurement: " + incriments);
            //          <----------------------------------------->
            int previousSum = 0;
            for (int i = 0; i < depthDataList.Count; i++)
            {
                int first;
                int second;
                int third;
                if (i < depthDataList.Count && i >= 2)
                {
                    first = depthDataList[i - 2];
                    second = depthDataList[i - 1];
                    third = depthDataList[i];

                    int sum = first + second + third;
                    if (sum > previousSum && previousSum != 0)
                    {
                        incriments++;
                    }
                    previousSum = sum;
                }
            }
            Console.WriteLine(incriments);
        }
    }
}

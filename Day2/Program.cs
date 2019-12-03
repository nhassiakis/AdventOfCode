using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = Imports.ImportCsv();
            RestoreGravityAssist(values);   
        }


        public static void RestoreGravityAssist(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == 0)
                {

                }
            }
        }
    }
}

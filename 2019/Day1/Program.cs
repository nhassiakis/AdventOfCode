using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fuelMass = Reader.ReadFile();
            CalcFuel(fuelMass);
        }

        public static void CalcFuel(List<int> fuelMass)
        {
            int total = 0;
            foreach (var item in fuelMass)
            {
                int currentMass = item;
                double floorIt = currentMass / 3;
                var thisMassFuel = Convert.ToInt32(Math.Floor(floorIt)) - 2;
                total += thisMassFuel;
                currentMass = thisMassFuel;
                while (thisMassFuel > 0)
                {
                    floorIt = currentMass / 3;
                    thisMassFuel = Convert.ToInt32(Math.Floor(floorIt)) - 2;
                    if (thisMassFuel > 0)
                    {

                        currentMass = thisMassFuel;
                        total += thisMassFuel;
                    }
                }
            }
            Console.WriteLine(total);
        }

    }
}

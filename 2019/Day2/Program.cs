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


        public static void RestoreGravityAssist(List<int> valuesOr)
        {
            int inputResult = 0;
            while (inputResult != 19690720)
            {
                int[] valuesChanged = new int[valuesOr.Count];
                for (int i = 0; i < valuesOr.Count; i++)
                {
                    valuesChanged[i] = valuesOr[i];
                }
                Random random = new Random();
                valuesChanged[1] = random.Next(0, 99);
                valuesChanged[2] = random.Next(0, 99);

                for (int i = 0; i < valuesChanged.Length; i++)
                {

                    int opcode = valuesChanged[i];
                    int inputOne = valuesChanged[i + 1];
                    int inputTwo = valuesChanged[i + 2];
                    int output = valuesChanged[i + 3];

                    if (opcode == 1)
                    {
                        inputResult = valuesChanged[inputOne] + valuesChanged[inputTwo];
                        valuesChanged[output] = inputResult;
                        if (valuesChanged[0] == 19690720)
                        {
                            Console.WriteLine("Value 1: " + valuesChanged[inputOne] + " Value 2: " + valuesChanged[inputTwo] + "\n ValueOfRan1: " + valuesChanged[1] + " valuesofRan2: " + valuesChanged[2] );
                        }
                    }
                    if (opcode == 2)
                    {
                        inputResult = valuesChanged[inputOne] * valuesChanged[inputTwo];
                        valuesChanged[output] = inputResult;
                        if (inputResult == 19690720)
                        {
                            Console.WriteLine("Value 1: " + valuesChanged[inputOne] + "Value 2: " + valuesChanged[inputTwo]);
                        }
                    }
                    if (opcode == 99)
                    {
                        
                        break;
                    }
                    i = i + 3;
                }
            }
        }
    }
}

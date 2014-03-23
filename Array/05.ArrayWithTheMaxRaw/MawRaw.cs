using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.ArrayWithTheMaxRaw
{
    class MawRaw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine()); 
            }
            int lenght = 1;
            int MaxLenght = 0;
            int elements = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 1; j < firstArray.Length; j++)
                {
                    if (firstArray[i] == firstArray[j])
                    {
                        lenght++;
                    }
                    if (lenght>MaxLenght)
                    {
                        MaxLenght = lenght;
                        elements = firstArray[i];
                    }
                }
                lenght = 1;
            }
            for (int i = 0; i < MaxLenght; i++)
            {
                Console.WriteLine(elements);
            }
        }
    }
}

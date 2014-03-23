using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.TwoCharArrays
{
    class CharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            char[] firstArray = new char[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            char[] secondArray = new char[4];
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = char.Parse(Console.ReadLine());
            }
            if (firstArray.Take(n).SequenceEqual(secondArray.Take(4))) 
            {
                Console.WriteLine("The two arrays are equal.");
            }
            else
            {
                Console.WriteLine("The two arrays r not equal.");
            }
        }
    }
}

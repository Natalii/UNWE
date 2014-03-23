using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[3];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i]=int.Parse(Console.ReadLine());
            }
            int[]secondArray = new int [3];
            for (int j = 0; j < secondArray.Length; j++)
			{
			 secondArray[j]=int.Parse(Console.ReadLine());
                
			}
            bool isEqual = false;
            if (firstArray.Length==secondArray.Length)
	        {
		        foreach (var numA in firstArray)
	            {
		            foreach (var numB in secondArray)
	                {
		                if (numA==numB)
	                        {
		                       isEqual=true;
	                        }
	                }
	            }
	        }
           Console.WriteLine(isEqual); 
        }

    }
}
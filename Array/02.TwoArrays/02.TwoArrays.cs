using System;

    class Program
    {
        static void Main()
        {
            int [] firstArray  = new int [5];
            for (int i = 0; i < firstArray.Length; i++)
			{
			 firstArray [i] = int.Parse(Console.ReadLine());
			}
            int [] secondArray = new int [8];
            for (int i = 0; i < secondArray.Length; i++)
			{
			 secondArray[i] = int.Parse(Console.ReadLine());
			}
            bool isEqual = true;
            if (firstArray.Length==secondArray.Length)
            {
                isEqual = true;
                
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
   }


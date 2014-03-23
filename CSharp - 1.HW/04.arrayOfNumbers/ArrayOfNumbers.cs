using System;

    class Program
    {
        static void Main()
        {
            int[] abcd = new int[4];
            for (int i = 0; i < abcd.Length; i++)
            {
                abcd[i] = int.Parse(Console.ReadLine());   
            }
            int sum = 0;
            for (int i = 0; i < abcd.Length; i++) 
            {
                sum = sum + abcd[i];
            }
            Console.WriteLine("The sum is:{0}",sum);
            for (int i = abcd.Length - 1; i >= 0; i--)
            {
                Console.Write(abcd [i]);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',30));
            for (int i = 0; i < abcd.Length; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}", abcd[3], abcd[1], abcd[2], abcd[0]); break;   
            }
        }
    }


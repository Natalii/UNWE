using System;

class Divisible
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int n = int.Parse(Console.ReadLine());
        bool isDivisible = false;
        if ((n % 5 == 0) && (n % 7 == 0))
        {
            isDivisible = true;
        }
         if (n==0)
        {
            isDivisible = false;   
        }
        else
        {
            isDivisible = false;
        }
        Console.WriteLine(isDivisible);

    }
}

using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int num = int.Parse(Console.ReadLine());
        if (num%2==1)
        {
            Console.WriteLine("The number is uncoutable.");
        }
        else if (num==0)
        {
            Console.WriteLine("Error");
        }
        else 
        {
            Console.WriteLine("The number is coutable.");
        }
    }
}


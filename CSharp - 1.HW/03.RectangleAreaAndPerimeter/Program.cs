using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a of the rectangle:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b of the rectangle:");
        double b = double.Parse(Console.ReadLine());
        double perim = 2 * (a + b);
        double area = (a * b);
        Console.WriteLine("{0:F2} {1:F2}",perim,area);
        
    }
}


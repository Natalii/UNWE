using System;

class PrimeNumCheck
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        bool primeNum = true;
        for (int divider = 2; divider < (number/2); divider++)
        {
            if (number%divider==0)
            {
                primeNum = false;
  
            }  

        }
        Console.WriteLine("The number {0} is prime{1}",number,primeNum);
    }
}


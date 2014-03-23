using System;

    class Divisiblenum
    {
        static void Main()
        {

            Console.WriteLine("Enter the beginning of the interval:");
            int startSequence = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the beginning of the interval:");
            int endSequence = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number:");         
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Make your choice:");
            Console.WriteLine("1.divise number by 3\n2.divise number by 4 \n3.divise number by 9");

            int choice = int.Parse(Console.ReadLine());
            int result = 0;
         
            switch (choice)

            {
                case 1:
                    result = num / 3;
                    Console.WriteLine("The number divided by three is {0}",result); break;
                case 2:
                    result = num / 4;
                    Console.WriteLine("The number divided by four is {0}",result); break;
                case 3:
                    result = num / 9;
                    Console.WriteLine("The number divided by nine is {0}", result); break;

                default: Console.WriteLine("Wrong input ! "); break;
            }        
        }
    }


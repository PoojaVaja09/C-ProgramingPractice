using System;

namespace EvenOddUsingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter startNumber:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter endNumber:");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even numbers are:");

            int i = startNumber;
            while (i <= endNumber)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                   
                }
                i++;
            }

            i = startNumber;
            Console.WriteLine();
            Console.WriteLine("Odd numbers are:");
            while (i <= endNumber)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    
                }
                i++;
            }



            Console.ReadLine();
        }
    }
}

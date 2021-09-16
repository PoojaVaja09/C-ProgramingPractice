using System;
using System.Diagnostics.Tracing;

namespace EvenOddUsingForLoop
 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the startNumber:");
            int startNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the endNumber: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("even numbers are:");
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (i % 2 == 0) 
                {
                    Console.Write(i + " ");
                }
               
            }
            Console.WriteLine("odd numbers are:");
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i %2 != 0) 
                {
                    Console.Write(i + " ");
                }
            }


            Console.ReadLine();

        }
    }
}

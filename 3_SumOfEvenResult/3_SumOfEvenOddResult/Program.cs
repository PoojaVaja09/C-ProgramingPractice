using System;

namespace _3_SumOfEvenOddResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the startNumber:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the endNumber: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            Console.WriteLine("even numbers are:");
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }

            }
            Console.WriteLine( );
            Console.WriteLine("Sum of even result is:{0}", sum);

            if (sum%2==0)
            {
                Console.WriteLine("Sum is Even ");
            }
            else
            {
                Console.WriteLine("Sum is Odd");
            }

        }
    }
}

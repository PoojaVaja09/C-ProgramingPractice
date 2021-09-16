using System;

namespace _5_SumOfOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the limlt : ");
            int L = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            Console.WriteLine("Odd numbers are:");
            for (int i = 1; i <= L; i++)
            {

                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Sum of odd result is:{0}", sum);

            Console.ReadLine();

        }
    }
}

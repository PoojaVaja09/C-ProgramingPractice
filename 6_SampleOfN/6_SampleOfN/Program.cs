using System;

namespace _6_SampleOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of M:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i=N-1;i>=M;i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

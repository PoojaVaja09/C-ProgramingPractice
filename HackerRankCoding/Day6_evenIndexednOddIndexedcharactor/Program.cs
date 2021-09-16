using System;

namespace Day6_evenIndexednOddIndexedcharactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of string T:");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= t; j++)
            {


                Console.WriteLine("Enter the string:");
                string s = Console.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(s[i]);
                    }
                }

                Console.Write("  ");

                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(s[i]);
                        
                    }
                    
                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }

    }
}

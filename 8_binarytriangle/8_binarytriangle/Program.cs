using System;
using System.Globalization;

namespace _8_binarytriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0;
            Console.WriteLine("Enter number of row:");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <= row; c++)
            {
                for (int r = 1; r <= c; r++)
                {
                   
                    if(a == 0)
                    {
                        a = 1;
                    }
                    else if (a == 1)
                    {
                        a = 0;
                    }

                    Console.Write(a);


                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

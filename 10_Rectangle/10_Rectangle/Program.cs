using System;

namespace _10_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of rectangle");
            int w = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<l; i++)
            {
                for(int j=0;j<w;j++)
                {
                    if(i==0||i==l-1||j==0||j==w-1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

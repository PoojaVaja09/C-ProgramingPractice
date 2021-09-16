using System;

namespace Day16_ExceptionStringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int s;
                s = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s);
            }
            catch(Exception)
            {
                Console.WriteLine("bad string");
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace Keyword_Long
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 12345;

            //printing value
            Console.WriteLine("num: " + num); //num:12345
            //printing type of variable
            Console.WriteLine("Type of num: " + num.GetType());//System.Int64
            //printing size
            Console.WriteLine("Size of a long variable: " + sizeof(long));//8 bytes
            //printing minimum & maximum value of long
            Console.WriteLine("Min value of long: " + long.MinValue);//-922..
            Console.WriteLine("Max value of long: " + long.MaxValue);//922..

        }
    }
}

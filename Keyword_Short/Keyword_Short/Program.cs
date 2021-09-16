using System;

namespace Keyword_Short
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = 12345;

            //printing value
            Console.WriteLine("num: " + num);//num:12345
            //printing type of variable
            Console.WriteLine("Type of num: " + num.GetType());//System.Int16
            //printing size
            Console.WriteLine("Size of a short variable: " + sizeof(short));//2 bytes
            //printing minimum & maximum value of short
            Console.WriteLine("Min value of short: " + short.MinValue);//-32768
            Console.WriteLine("Max value of short: " + short.MaxValue);//32767
        }
    }
}

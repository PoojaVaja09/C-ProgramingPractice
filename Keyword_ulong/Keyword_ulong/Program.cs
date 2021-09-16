using System;

namespace Keyword_ulong
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = 12345;

            //printing value
            Console.WriteLine("num: " + num);//num:12345
            //printing type of variable
            Console.WriteLine("Type of num: " + num.GetType());//System.UInt64
            //printing size
            Console.WriteLine("Size of a ulong variable: " + sizeof(ulong));//8
            //printing minimum & maximum value of ulong
            Console.WriteLine("Min value of ulong: " + ulong.MinValue);//0
            Console.WriteLine("Max value of ulong: " + ulong.MaxValue);//1844...

        }
    }
}

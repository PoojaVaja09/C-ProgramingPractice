using System;

namespace Keyword_ushort
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num = 12345;

            //printing value
            Console.WriteLine("num: " + num);//num:12345
            //printing type of variable
            Console.WriteLine("Type of num: " + num.GetType());//System.UInt16
            //printing size
            Console.WriteLine("Size of a ushort variable: " + sizeof(ushort));//2 bytes
            //printing minimum & maximum value of ushort
            Console.WriteLine("Min value of ushort: " + ushort.MinValue);//0
            Console.WriteLine("Max value of ushort: " + ushort.MaxValue);//65535
        }
    }
}

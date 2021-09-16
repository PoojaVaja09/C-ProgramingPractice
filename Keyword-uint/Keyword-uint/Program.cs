using System;

namespace Keyword_uint
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 12345;

            //printing value
            Console.WriteLine("num: " + num);//num:12345
            //printing type of variable
            Console.WriteLine("Type of num: " + num.GetType());//Sytem.UInt32
            //printing size
            Console.WriteLine("Size of a uint variable: " + sizeof(uint)); //4 bytes
            //printing minimum & maximum value of uint
            Console.WriteLine("Min value of uint: " + uint.MinValue);//0
            Console.WriteLine("Max value of uint: " + uint.MaxValue);//4294...
        }
    }
}

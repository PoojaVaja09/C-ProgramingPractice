using System;

namespace Keyword_Byte
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte num = 120;
            Console.WriteLine("num is:"+num);
            Console.WriteLine("Type of num is:" + num.GetType());
            Console.WriteLine("Size of byte variable is:" + sizeof(byte));
            Console.ReadLine();
        }
    }
}

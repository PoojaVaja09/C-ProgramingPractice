using System;

namespace Keyword_decimal
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal num = 12.868769m;
            Console.WriteLine("number is :" + num);
            Console.WriteLine("num :" + num.GetType());
            Console.WriteLine("Size of decimal is:" + sizeof(decimal));
        }
    }
}

using System;

namespace Keyword_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            Console.WriteLine("Number is:" + num );
            Console.WriteLine("Type of number is :" + num.GetType());
            Console.WriteLine(" Size of int is:" + sizeof(int));
            Console.WriteLine("Min value of int: " + int.MinValue);
            Console.WriteLine("Max value of int: " + int.MaxValue);

        }
    }
}

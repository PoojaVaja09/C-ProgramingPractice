using System;

namespace Keyword_Double
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num = 1245.6789;

            Console.WriteLine("num: " + num);
            
            Console.WriteLine("Type of num: " + num.GetType());
            Console.WriteLine("Size of a double variable: " + sizeof(double));
            Console.WriteLine("Min value of double: " + double.MinValue); //-1.79...
            Console.WriteLine("Max value of double: " + double.MaxValue);//1.79
        }
    }
}

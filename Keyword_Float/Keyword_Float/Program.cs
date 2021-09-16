using System;

namespace Keyword_Float
{
    class Program
    {
        public static void Main(string[] args)
        {
            float num = 1235.6789f;

            Console.WriteLine("num: " + num); //num = 12345.6789
           
            Console.WriteLine("Type of num: " + num.GetType()); 
            
            Console.WriteLine("Size of a float variable: " + sizeof(float)); 
            
            Console.WriteLine("Min value of float: " + float.MinValue);
            Console.WriteLine("Max value of float: " + float.MaxValue);
        }
    }
}

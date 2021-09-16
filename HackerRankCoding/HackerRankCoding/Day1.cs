using System;

namespace HackerRankCoding
{
    class Day1
    {
        static void Main(string[] args)
        {
            //string inputString;

            //inputString = Console.ReadLine();
            //Console.WriteLine("Hello World");
            //Console.WriteLine(inputString);
            //Console.ReadLine();
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int myInt;
            double myDouble;
            string myString;

            myInt = Convert.ToInt32(Console.ReadLine());
            myDouble = Convert.ToDouble(Console.ReadLine());
            myString = Console.ReadLine();

            int intSum = i + myInt;
            Console.WriteLine(intSum);

            double doubleSum = d + myDouble;
            Console.WriteLine(doubleSum);

            string newString = s + myString;
            Console.WriteLine(newString);

            Console.ReadLine();



        }
    }
}

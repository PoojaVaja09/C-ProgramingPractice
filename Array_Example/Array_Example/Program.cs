using System;

namespace Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] marks1 = { 99, 78, 90, 91 };//declaring +initializingon stack

            int[] marks = new int[5];//marks[5]-->on heap

            marks[0] = 99;
            marks[1] = 90;
            marks[2] = 95;
            marks[3] = 80;
            marks[4] = 88;

            foreach (int mark in marks)
            {
                Console.WriteLine("Marks:"+mark);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach  (string car in cars)
            {
                Console.WriteLine("Cars:" + car);
            }





            Console.ReadLine();
        }
    }
}

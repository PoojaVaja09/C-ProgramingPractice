using System;
using System.Linq;

namespace Day7_ArrayReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of an Array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            string input = Console.ReadLine();

            //Console.WriteLine(input);

            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = Convert.ToInt32(numbers[i]);
            }


            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(array);

            //for (int j = 0; j < n; j++)
            //{
            //    Console.WriteLine(array[j]);
            //}
            
            for (int j = array.Length-1; j >=0; j--)
            {
                Console.Write(array[j] + " ");
            }

            Console.ReadLine();
        }
    }
}

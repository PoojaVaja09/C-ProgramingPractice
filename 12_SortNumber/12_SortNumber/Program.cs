using System;

namespace _12_SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[3];
            array[0] = num1;
            array[1] = num2;
            array[2] = num3;

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }




            


        }
    }
}

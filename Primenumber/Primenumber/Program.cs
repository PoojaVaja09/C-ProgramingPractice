using System;
using System.Globalization;

namespace Primenumber
{
    class Primenumber
    {
        static void Main(string[] args)
        {
           

                Console.Write("Enter The Number: ");
                int Number = Convert.ToInt32(Console.ReadLine());



            for (int j = 2; j <= Number; j++)
            {
                if (Number % j == 0)
                {
                    Console.WriteLine(Number + "is PrimeNumber");
                    break;

                }
            }
            
                Console.ReadLine();
            
            
        }
    }
}

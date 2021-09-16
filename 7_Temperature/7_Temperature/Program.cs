using System;
using System.Linq;

namespace _7_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int ArraySize = Convert.ToInt32(Console.ReadLine());

            double[] Temps = new double[ArraySize];
            
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine("Enter value of temperature:");
                double t =  Convert.ToDouble(Console.ReadLine());
                Temps[i] = t;
            }

            double Min = Temps.Min();
            Console.WriteLine(" Minimum Temperature is:{0}", Min);

            double Max = Temps.Max();
            Console.WriteLine(" Maximum Temperature is:{0}", Max);
            Console.ReadLine();
        }
    }

}

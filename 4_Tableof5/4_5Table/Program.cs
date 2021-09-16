using System;
using System.Runtime.InteropServices;

namespace _4_5Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying table of 5 until limit is 30");
            Console.WriteLine();
            int Limit = 30;



            int[] r = new int[Limit];
            int t = 5;

            for (int i = 1; i <= Limit; i++)
            {
                int result = t * i;
                Console.Write("{0} * {1} = {2} \n", t, i, result);
                r[i-1] = result;
                


            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Displaying the array");
            Console.WriteLine();

            int[] even = new int[Limit / 2];
            int evenindex = 0;
            int[] odd = new int[Limit / 2];
            int oddindex = 0;

            for (int i=0;i<r.Length;i++)
            {
                Console.Write(r[i] +" ");

                if(r[i]%2==0)
                {
                    even[evenindex]=r[i];
                    evenindex++;
                }
                else
                {
                    odd[oddindex] = r[i];
                    oddindex++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Displaying even Result");

            
            for (int i = 0; i < even.Length; i++) 
            {
                Console.Write(even[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Count of even result is {0}:", even.Length);

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Displaying odd Result");

            for (int i = 0; i < odd.Length; i++) 
            {
                Console.Write(odd[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count of odd result is {0}:", odd.Length);

        }
    }
}

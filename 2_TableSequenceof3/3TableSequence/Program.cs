using System;

namespace _3TableSequence
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
            Console.Write("Display the multiplication table sequnce till:");
            int k = Convert.ToInt32(Console.ReadLine());
            
            

            Console.Write("Input the number (Table to be calculated) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int j = 1; j <= k; j++)
            {

                Console.Write("{0} * {1} = {2} \n", n, j, n * j);
                
                
            }
            Console.ReadLine();
        }
        
    }
}   

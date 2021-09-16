using System;
using System.Data;

namespace HelloWorldIndividual
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            Console.WriteLine("Enter the string S:");
            S = Console.ReadLine();
            int length = S.Length;
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(S[i]);
            }

            Console.WriteLine("HelloWorld");
            try
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception Message:" + Ex.Message);
            }
            finally
            {
                Console.WriteLine("Argument Statement Executed");
            }

            Test test = new Test();
            Console.WriteLine(test.age);

            Test test1 = new Test(25, "Hello World");
           
            Console.WriteLine(test1.age);
          
            test1.Display();
            test1.Display_Char();
            Console.ReadLine();

        }
            
    }
}

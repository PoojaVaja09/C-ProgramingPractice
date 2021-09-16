using System;

namespace Try_Catch_Example
{
    class Program
    {
        public static void ProcessString(string s)
        {
            if(s==null)
            {
                throw new ArgumentNullException();
                //throw new Exception();//goes to second catch block;
            }

        }
        public static void Main(string[] args)
        {
            try
            {
                string s = null;
                ProcessString(s);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("First Exeption Caugth:" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Second Exeption Caugth:" + e.Message);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Keyword_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool variable declaration
            bool answer = true;

            //printing value
            Console.WriteLine("answer: " + answer);//true
            //printing type of variable
            Console.WriteLine("Type of answer: " + answer.GetType()); //System.Boolean
            //printing size of a bool 
            Console.WriteLine("Size of a bool variable: " + sizeof(bool)); //1
        }
    }
}

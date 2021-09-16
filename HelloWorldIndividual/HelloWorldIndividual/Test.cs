using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HelloWorldIndividual
{
    class Test
    {
        //Atrributes or member variables
        public int age;
        private string info;

        //user defined default constructor
        public Test()
        {
            age = 25;
        }
        //parameterised ctor
        public Test(int ageParam, string messasge)
        {
            age = ageParam;
            info = messasge;
        }
        //Method or function
        public void Display()
        {
            Console.WriteLine(info);
        }

        public void Display_Char()
        {
            for (int i = 0; i < info.Length; i++)
            {
                Console.WriteLine("For char value is:" + info[i]);
            }

            foreach(char c in info)
            {
                Console.WriteLine("Foreach char value is:" + c);
            }

            // enters only if condition is true
            int j = 0;
            while (j<info.Length)
            {
                Console.WriteLine("While char value is:" + info[j]);
                j++;
            }

            //does enter once irresprctive of condition then checks for condition 
            int k = 0;
            do
            {
                Console.WriteLine("Do while char value is:" + info[k]);
                k++;
            } while (k<info.Length);




        }
            
            

    }

}


    


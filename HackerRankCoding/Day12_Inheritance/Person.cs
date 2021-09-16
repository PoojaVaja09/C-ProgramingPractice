using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Inheritance
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int id;
        public void printPerson()
        {
             Console.WriteLine("Name:" + lastName + "," + firstName);
             Console.WriteLine("ID:" + id);
            

        }
    }
}

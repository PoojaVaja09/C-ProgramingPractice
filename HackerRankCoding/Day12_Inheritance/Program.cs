using System;
using System.Collections.Generic;
using System.Linq;

namespace Day12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of scores:");
            int numScore = Convert.ToInt32(Console.ReadLine());
            string[] Scores=(Console.ReadLine().Split(' '));
            int[] intscores = new int[Scores.Length];
            for (int i = 0; i < Scores.Length; i++)
            {
                intscores[i] = Convert.ToInt32(Scores[i]);
            }
            

            Student s = new Student(firstName, lastName, id, intscores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadLine();

        }
    }


     class Student : Person
    {
         private int[] score;
        public Student(string fName, string lName, int studentId, int[] score)
        {
            base.firstName = fName;
            base.lastName = lName;
            base.id = studentId;
            this.score = score;
        }
        public char Calculate()
        {
            double average = score.Average();
            if (average >= 90 && average <= 100)
            {

                return 'O';
            }
            else if (average >= 80 && average < 90)
            {

                return 'E';
            }
            else if (average >= 70 && average < 80)
            {

                return 'A';
            }
            else if (average >= 55 && average < 70)
            {

                return 'P';
            }
            else if (average >= 40 && average < 55)
            {

                return 'D';
            }
            else
            {

                return 'T';
            }


        }
    }
    
}

using System;
using System.Diagnostics.Tracing;

namespace Assessment3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "John", 7000, "MindTree");
            Employee employee2 = new Employee(102, "Peter", 8000, "MindTree");
            Employee employee3 = new Employee(103, "Mark", 9000, "MindTree");

            Employee.PrintEmployeeDetails(employee1);

            Employee senioremp = Employee.GetSeniorEmployeeDetails(employee1, employee2);
            Console.WriteLine("Senior Employee Detail:");
            Console.WriteLine("Emp No: {0}, Name: {1}, Salary: {2}, Company Name: {3}", senioremp.EmpNo, senioremp.EmpName, senioremp.EmpSalary, senioremp.CompanyName);
            
            Console.ReadLine();
        }

        


    }
}

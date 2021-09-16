using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3
{
    public  class Employee
    {
        public int EmpNo;
        public string EmpName;
        public double EmpSalary;
        public string CompanyName;

        public Employee(int aEmpNo, string aEmpName, double aEmpSalary, string aCompanyName)
        {
            EmpNo = aEmpNo;
            EmpName = aEmpName;
            EmpSalary = aEmpSalary;
            CompanyName = aCompanyName;
        }


        public static void PrintEmployeeDetails(Employee emp)
        {
            Console.WriteLine("******** Employee Details*******");
            Console.WriteLine("Emp No: {0}, Name: {1}, Salary: {2}, Company Name: {3}", 
               emp.EmpNo, emp.EmpName, emp.EmpSalary, emp.CompanyName);
            //Console.WriteLine("Emp No:" + emp.EmpNo, "Name:" + emp.EmpName, "salary:" + emp.EmpSalary, "Company Name:" + emp.CompanyName);
           
        }

        public static Employee GetSeniorEmployeeDetails(Employee emp1, Employee emp2)
        {
            if (emp1.EmpSalary>emp2.EmpSalary)
            {
                //Console.WriteLine("Employee1 is senior");
                return emp1;
                
            }
            else
            {
                //Console.WriteLine("Employee2 is senior");
                return emp2;
            }
            
        }




    }
}

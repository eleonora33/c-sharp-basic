using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharpBasic.Homework7.Library
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Role EmployeeRole { get; set; }
        protected double Salary;

        public Employee(string firstName, string lastName, Role employeeRole, double salary)
        {
            Firstname = firstName;
            Lastname = lastName;
            EmployeeRole = employeeRole;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Firstname} {Lastname} {GetSalary()}");
        }

        public virtual double GetSalary() => Salary;
    }
}

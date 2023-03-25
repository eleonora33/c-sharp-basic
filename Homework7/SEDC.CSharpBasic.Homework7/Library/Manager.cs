using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharpBasic.Homework7.Library
{
    public class Manager : Employee
    {
        private double _bonus;

        public Manager(string firstName, string lastName, Role employeeRole, double salary) 
            : base(firstName, lastName, employeeRole, salary)
        {
        }

        public void AddBonus(double amount)
        {
            _bonus += amount;
        }

        public override double GetSalary() => Salary + _bonus;
    }
}

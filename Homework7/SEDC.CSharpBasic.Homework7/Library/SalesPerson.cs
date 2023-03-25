using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharpBasic.Homework7.Library
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue;
        
        public SalesPerson(string firstName, string lastName, double successSaleRevenue)
            : base(firstName, lastName, Role.Sales, 500D)
        {
            _successSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double amount)
        {
            _successSaleRevenue += amount;
        }

        public override double GetSalary()
        {
            double bonus;

            if (_successSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else
            {
                bonus = 1500;
            }
           
            return Salary + bonus;
        }
    }
}

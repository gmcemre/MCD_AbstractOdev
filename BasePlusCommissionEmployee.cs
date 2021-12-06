using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    public class BasePlusCommissionEmployee : CommissionEmployee 
    {
        public double  baseSalary { get; set; }

        public override double Earnings()
        {
            double earnings = (commissionRate * grossSales) + baseSalary;
            return earnings ;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " - " + "Social Security Number: " + SSN + " - " + "Earnings : " + Earnings() + "$";
        }
    }
}

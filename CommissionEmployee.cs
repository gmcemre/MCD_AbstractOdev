using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    public class CommissionEmployee : Employee
    {
        public double  grossSales { get; set; }
        public double  commissionRate { get; set; }

        public override double Earnings()
        {
            double earnings = grossSales * commissionRate;
            return earnings;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " - " + "Social Security Number: " + SSN + " - " + "Earnings : " + Earnings() + "$";
        }
    }
}

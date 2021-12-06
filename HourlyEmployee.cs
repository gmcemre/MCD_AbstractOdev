using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    public class HourlyEmployee : Employee
    {
        public double wage { get; set; }
        public double hours { get; set; }
        
        public override double Earnings()
        {
            double earnings;
            if (hours <= 40)
            {
                 earnings = wage * hours;
            }
            else
            {
                 earnings=(40*wage) +(hours-40)*wage*1.5;
            }

            return earnings ;

        }

        public override string ToString()
        {

            return  firstName + " " + lastName + " - " + "Social Security Number: " + SSN + " - " + "Earnings : " + Earnings() + "$";
        }
    }
}

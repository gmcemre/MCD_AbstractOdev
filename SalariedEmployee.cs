using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    public class SalariedEmployee : Employee
    {
        public double weeklySalary { get; set; }


        public override double Earnings( )
        {
            return weeklySalary=100;
        }

        public override string ToString()
        {
            string  earnings= Convert .ToString (weeklySalary); 
            return firstName + " " + lastName + " - " + "Social Security Number: " + SSN+" - "+"Earnings: "+weeklySalary  +"$";
        }
    }
}

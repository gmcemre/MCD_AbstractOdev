using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Abstract Uygulama *****");
            Console.WriteLine();
            SalariedEmployee S1 = new SalariedEmployee();
            S1.firstName = "Emre";
            S1.lastName  = "Gemici";
            S1.SSN = 123450001;
            S1.Earnings();
            S1.ToString();
            Console.WriteLine(S1.ToString ());

            HourlyEmployee H1 =new  HourlyEmployee();
            H1.firstName = "Selim";
            H1.lastName = "Gemici";
            H1.SSN = 123450002;
            H1.wage = 100;
            H1.hours = 47;
            H1.Earnings();
            Console.WriteLine(H1.ToString());

            CommissionEmployee  C1 = new CommissionEmployee ();
            C1.firstName = "Araz";
            C1.lastName = "Gemici";
            C1.SSN = 123450003;
            C1.grossSales  = 100;
            C1.commissionRate  = 10;
            C1.Earnings();
            Console.WriteLine(C1.ToString());

            BasePlusCommissionEmployee  B1 = new BasePlusCommissionEmployee ();
            B1.firstName = "Deniz";
            B1.lastName = "Gemici";
            B1.SSN = 123450004;
            B1.baseSalary = 1500;
            B1.grossSales = 100;
            B1.commissionRate = 10;
            B1.Earnings();
            Console.WriteLine(B1.ToString());




            Console.ReadKey();
        }
    }
}

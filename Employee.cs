using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractOdev
{
    public abstract class Employee
    {
        public string  firstName { get; set; }
        public string  lastName { get; set; }
        public int SSN { get; set; }

        public abstract double Earnings( );
        
        
    }
}

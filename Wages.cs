using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Wages:Employee
    {
        public double rate;

        public double hours;

        private Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {

        }

        private GetPay() { }

        public string ToString() { }
    }
}

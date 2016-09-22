using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    public class PartTimeEmployee : Employee
    {
        private double wage;
        private double hours;

        public PartTimeEmployee(String name, DateTime dob, double wage, double hours) : base(name, dob)
        {
            //super(name, dob);
            this.wage = wage;
            this.hours = hours;
        }

        public double getWage()
        {
            return this.wage;
        }

        public double setWage(double wage)
        {
            return this.wage = wage;
        }

        public double getHours()
        {
            return this.hours;
        }

        public double setHours(double hours)
        {
            if (hours > 0)
            {
                return this.hours = hours;
            }
            else
            {
                return this.hours = 0;
            }
        }

        public override double pay()
        {
            return wage * hours;
        }
    }

}

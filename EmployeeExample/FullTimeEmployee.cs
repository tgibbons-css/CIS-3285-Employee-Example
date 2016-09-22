using System;

namespace EmployeeExample
{
    public class FullTimeEmployee : Employee
    {
        //private data


        public FullTimeEmployee(String name, DateTime dob, double salary)
                : base(name, dob)
        {
            //super(name, dob);
            this.salary = salary;
        }

        private double salary;
        public double Salary
        {
            get { return this.salary; }
            set {

                if (value > 0)
                    this.salary = value;
                else
                    this.salary = 0;
            }
        }
       

        public override double pay()
        {
            return this.salary / 52;
        }

    }
}
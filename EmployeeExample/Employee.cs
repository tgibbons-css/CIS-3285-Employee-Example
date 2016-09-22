using System;

namespace EmployeeExample
{
    public abstract class Employee
    {
        // instance variables - replace the example below with your own
        
        

        public Employee(String name, DateTime dob)
        {
            this.name = name;
            this.dob = dob;
        }

        private String name;
        public String Name
        {
            get { return this.name; }
            set { name = value; }
        }

        //public String getName() { return this.name; }
        //public void setName(String name) { this.name = name; }

        protected DateTime dob;
        public DateTime getDOB() { return this.dob; }
        public void setDOB(DateTime dob) { this.dob = dob; }

        public abstract double pay();
    }
}
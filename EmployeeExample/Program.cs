using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee("Jen", new DateTime(75, 1, 22), 75000);
            PartTimeEmployee emp2 = new PartTimeEmployee("Dave", new DateTime(75, 1, 22), 15.00, 30.00);
            Employee emp3 = new FullTimeEmployee("Tom", new DateTime(70, 1, 22), 80000);
            emp2.Name = "David";

            Console.WriteLine("First Employee name is " + emp1.Name);
            Console.WriteLine("   This person should be paid " + emp1.pay());
            Console.WriteLine("Second Employee name is " + emp2.Name);
            Console.WriteLine("   This person should be paid " + emp2.pay());
            Console.WriteLine("Third Employee name is " + emp3.Name);
            Console.WriteLine("   This person should be paid " + emp3.pay());


        }
    }
}

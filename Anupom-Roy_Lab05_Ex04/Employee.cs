using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex04
{
    public class Employee
    {
        public string Name { get; set; }
        public double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    salary = 2000.0;
            }
        } // end Salary property
        public Employee(string name, double empSalary)
        {
            Name = name;
            Salary = empSalary;
        }
        public override string ToString() => $"Employee: {Name}  Salary: {Salary:C}";
    }
}

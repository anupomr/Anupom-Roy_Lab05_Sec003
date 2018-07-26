using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex04
{
   public class Program
    {
          static SortedDictionary<int, Employee> empDict = new SortedDictionary<int, Employee>();
          static Employee[] employeeList = new Employee[] {
            new Employee("Anupom Roy",66700),
            new Employee("Bill Gates",662300),
            new Employee("Adric Roy",666000),
            new Employee("Sundor Pichi",606000),
            new Employee("Chandan Gates",676000)
        };
        static void Main(string[] args)
        {            
            AddDictionaryItem(empDict, employeeList);
            Console.WriteLine("****** Employee Dictionary ******");
            PrintDictionary(empDict);
        }
       private static void AddDictionaryItem(SortedDictionary<int, Employee> var, Employee[] emp)
        {
            for (int i = 0; i < emp.Length; ++i)
            {
                empDict.Add(i,emp[i]);
            }
        }
        private static void PrintDictionary(SortedDictionary<int, Employee> varEmp)
        {
            foreach (var item in varEmp.Keys)
            {
                Console.WriteLine($" {varEmp[item]}");
            }
        }
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> var)
        {

        }
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> var)
        {

        }
    }
}

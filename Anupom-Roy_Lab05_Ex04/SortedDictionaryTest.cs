using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex04
{
   public class SortedDictionaryTest
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
            
            Console.WriteLine("****** After Remove ******");

            RemoveDictionaryItem(empDict,1);
            PrintDictionary(empDict);
            Console.WriteLine("****** Max Salary for an Employee  ******");
            MaxDictionaryItem(empDict);
            SearchDictionaryItem(empDict, 1);

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
            //foreach (var item in varEmp.Keys)
            //{
            //    Console.WriteLine($" {varEmp[item]}");

            //}
            foreach (KeyValuePair<int, Employee> item in varEmp)
            {
                Console.WriteLine($" {item.Key, 2} {item.Value, 2}");
            }

        }
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> dict,int key)
        {
            dict.Remove(key);
           // foreach (var k in dict.Keys.OrderBy(k => k).Take(key).ToArray()) dict.Remove(k);
        }
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> var, int key)
        {
            if (var.ContainsKey(key))
            {
                Console.WriteLine($"Key: {key} is Found !!!");
            }
            else
            {
                Console.WriteLine($"Key is Not Found !!!");
            }
        }
        protected static void MaxDictionaryItem(SortedDictionary<int, Employee> varEmp)
        {
            double max = 0.0;
            foreach (KeyValuePair<int, Employee> item in varEmp)
            {               
                if (item.Value.Salary>max)
                {
                    max  = item.Value.Salary;
                }                
            }
            Console.WriteLine($" Max Salary:  {max:c}");
        }  
    }
}

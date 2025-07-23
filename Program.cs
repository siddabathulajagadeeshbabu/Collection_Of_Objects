using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Based on Collection of objects using list<T> and Dictionary <TKey ,TValue>");
            Console.WriteLine("How List<t> and Dictionary<key,Tvalue> are implemented");
            Console.WriteLine("");

            //step 1:create a list of employees objects wihich is ollection of objects
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Alice", "HR"),
                new Employee(2, "Bob", "IT"),
                new Employee(3, "Charlie", "Finance")
            };
            //step 2:Dispaly the list of employees
            Console.WriteLine("List of Employees:");
            foreach (var item in employees)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}");
            }


            //step 3: Create a dictionary to store employees by their ID this will help in quick lookups ex searching,sorting,et
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
            //step 4: Populate the dictionary with employees
            foreach (var Employee in employees)
            {
                employeeDictionary[Employee.Id] = Employee; //using Id as key

            }
            //step 6: Perfoming looups using the dictionary  is searching for an employee by ID
            Console.WriteLine("\n Enter an Employee ID to search:");
            int searchId = Convert.ToInt32(Console.ReadLine());
            if (employeeDictionary.TryGetValue(searchId, out Employee foundEmp))
            {
                Console.WriteLine($"Found Employee: Id: {foundEmp.Name}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
            



        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public Employee(int id, string name, string department)
            {
                Id = id;
                Name = name;
                Department = department;
            }

        }
    }
}
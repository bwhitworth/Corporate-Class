using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corporate_Class
{
    // Copy this Company class into a new file within your project.
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> Employees = new List<Employee>();

        // Create a method that allows a caller to add an employee
        public void AddEmployee(string name, string jobTitle)
        {
            var newEmployee = new Employee(name, jobTitle);
            Employees.Add(newEmployee);
        }

        // Create a method that allows a caller to remove an employee
        public void RemoveEmployee(string name)
        {
            var employeeToRemove = Employees.Find(e => e.Name == name);
            Employees.Remove(employeeToRemove);
        }

        // Create a method that allows a caller to retrieve the list of employees
        public void ListAllEmployees()
        {
            Console.WriteLine($"Employees of {Name}:");
            foreach (var empl in Employees)
            {
                Console.WriteLine($"{empl.Name} = {empl.JobTitle}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
    }
}

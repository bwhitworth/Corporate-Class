using System;

namespace Corporate_Class
{
    // Create a class that contains information about employees of a company
    // and define methods to get/set employee name, job title, and start date.
    internal class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = DateTime.Today;
        }
    }
}
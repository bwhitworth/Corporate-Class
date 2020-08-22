using System;

namespace Corporate_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main method,

            // 1. instantiate a new company
            var Amazon = new Company("Amazon", DateTime.Today);
            Console.WriteLine($"New company made on {Amazon.CreatedOn}: {Amazon.Name}");

            // 2. create three employees and assign them to the company
            Amazon.AddEmployee("Jeff", "CEO");
            Amazon.AddEmployee("Mike", "Operations Manager");
            Amazon.AddEmployee("Gail", "Human Resources");

            // Upddate the Company class to write the name of each employee to the console.
            Amazon.ListAllEmployees();

        }
    }
}

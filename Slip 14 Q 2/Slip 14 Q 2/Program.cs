using System;

namespace Slip_14_Q_2
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        class Employee : Person
        {
            public string Staffed { get; set; }
            public double Salary { get; set; }

            public void Display()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Address: " + Address);
                Console.WriteLine("Staffed: " + Staffed);
                Console.WriteLine("Salary: " + Salary);
                Console.WriteLine("----------------------------");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee[] e = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                e[i] = new Employee();

                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.Write("Enter Name: ");
                e[i].Name = Console.ReadLine();

                Console.Write("Enter Address: ");
                e[i].Address = Console.ReadLine();

                Console.Write("Enter Staffed: ");
                e[i].Staffed = Console.ReadLine();

                Console.Write("Enter Salary: ");
                e[i].Salary = Convert.ToDouble(Console.ReadLine()); // ✅ fixed here
            }

            Console.WriteLine("\n--- Employee Details ---");
            for (int i = 0; i < n; i++)
            {
                e[i].Display();
            }
        }
    }
}
 
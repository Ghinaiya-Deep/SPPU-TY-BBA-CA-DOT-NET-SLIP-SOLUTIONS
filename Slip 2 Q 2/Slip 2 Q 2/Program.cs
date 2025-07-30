using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_2_Q_2
{
    using System;

    class Department
    {
        public string Name { get; set; }
        public int Employeecount { get; set; }

        public virtual void Accept()
        {
            Console.Write("Enter Departement : ");
            Name = Console.ReadLine();
            Console.Write("Enter Employee Count : ");
            Employeecount = int.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine($"Department : {Name}, Employee Count : {Employeecount}");
        }
    }

    class Sales : Department
    {
        public double sales { get; set; }
        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Sales Target : ");
            sales = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Sales Target : {sales}");
        }
    }


    class HumanResource : Department
    {
        public int Training { get; set; }
        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Number of Training Sessions : ");
            Training = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Training Sessions : {Training}");
        }
    }

    class Program
    {
        static void Main()

        {
            Sales s = new Sales();
            HumanResource hr = new HumanResource();

            Console.WriteLine("Enter Sales Department Deatils : ");
            s.Accept();
            Console.WriteLine("Enter Human Resource Department Details : ");
            hr.Accept();

            s.Display();
            Console.WriteLine();
            hr.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_13_Q_2
{
    internal class Program
    {
        class Student
        {
            public int roll {  get; set; }
            public string Name { get; set; }
            public int m1 { get; set; }
            public int m2 { get; set; }
            public int m3 { get; set; }

            public double cal_per()
            {
                return (m1 + m2 + m3) / 3.0;
            }

            public void Display()
            {
                Console.WriteLine("Roll no : " + roll);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Percentage : "+ cal_per() +"%");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Student : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] s = new Student[n];

            for (int i = 0; i < n; i++)
            {
                s[i] = new Student();

                Console.WriteLine("Enter Roll Number : ");
                s[i].roll = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                s[i].Name = Console.ReadLine();

                Console.WriteLine("Enter marks 1 : ");
                s[i].m1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks 2 : ");
                s[i].m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks 3 : ");
                s[i].m3 = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            { 
            s[i].Display();
        }
        }
    }
}

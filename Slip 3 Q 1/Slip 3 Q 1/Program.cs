using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_3_Q_1
{
    class Program
    {

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = Add(n1, n2);
            Console.WriteLine("The sum of 2 number is : " + sum);
        }
    }
}

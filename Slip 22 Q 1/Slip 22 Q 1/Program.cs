using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_22_Q_1
{
    internal class Program
    {
        static void swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter value of a : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping : ");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            swap(a,b);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_24_Q_1
{
    internal class Program
    {
        static void is_prime(int n)
        {
            int flag = 0;
            for (int i = 2; i < n - 1; i ++)
            {
                if(n%2==0)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag==0)
            {
                Console.WriteLine(n + " is a Prime Number ");
            }
            else
            {
                Console.WriteLine(n + " is not Prime Number");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Number : ");
            n=Convert.ToInt32(Console.ReadLine());
            is_prime(n);
        }
    }
}

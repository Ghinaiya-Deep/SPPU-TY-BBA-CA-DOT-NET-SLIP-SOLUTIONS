6u0sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slip_28_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i;
            int[] arr = new int[15];
            Console.WriteLine("Enter Number of Array Elements : ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + n + "Elements : ");
            for(i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Array is : ");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(" " + arr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Reverse Array is : ");
            for(i=n-1;i>=0;i--)
            {
                Console.WriteLine(" " + arr[i]);
            }
          
        }
    }
}

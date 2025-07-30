using System;


namespace Slip_14_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[20];
            int sum = 0;

            Console.WriteLine("Enter Number of Elements : ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Elements : ");
            for(int i = 0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
                sum=sum+arr[i];
            }

            Console.WriteLine("The Sum of Array Elements are : " + sum);
        }
    }
}

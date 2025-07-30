using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] A = new int[rows, cols];
        int[,] B = new int[rows, cols];
        int[,] result = new int[rows, cols];

        Console.WriteLine("\nEnter elements of Matrix A:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEnter elements of Matrix B:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"B[{i},{j}] = ");
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix multiplication
        Console.WriteLine("\nMultiplying Matrices...");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Display result
        Console.WriteLine("\nResultant Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

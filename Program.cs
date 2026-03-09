using System;

namespace Workshop3
{
    public class MatrixOperation
    {
        public int M { get; set; }
        public int N { get; set; }
        public int P { get; set; }

        // Constructor
        public MatrixOperation(int m, int n, int p)
        {
            M = m;
            N = n;
            P = p;
        }
        public void CalculateAndShow()
        {
            int[,] matrixA = new int[M, N];
            int[,] matrixB = new int[N, P];
            int[,] matrixC = new int[M, P];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrixA[i, j] = (i + 1) * j;
                }
            }
            // Filling matrix B: (j+1)*i (be careful, formula changes)
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    // this is (j+1)*i according to what it says
                    matrixB[i, j] = (j + 1) * i;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < N; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    matrixC[i, j] = sum;
                }
            }

            // Showing results
            Console.WriteLine("\n*** Matrix A ***");
            DisplayMatrix(matrixA, M, N);

            Console.WriteLine("\n*** Matrix B ***");
            DisplayMatrix(matrixB, N, P);

            Console.WriteLine("\n*** Resulting Matrix C ***");
            DisplayMatrix(matrixC, M, P);
        }
        private void DisplayMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine(); // line break after finishing the row
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EXERCISE 33: MATRIX MULTIPLICATION ===");
            try
            {
                Console.Write("Enter the value for m: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the value for n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the value for p: ");
                int p = Convert.ToInt32(Console.ReadLine());

                // Creating the object and calling the method
                MatrixOperation op = new MatrixOperation(m, n, p);
                op.CalculateAndShow();
            }
            catch
            {
                Console.WriteLine("Error: Only integers are allowed.");
            }

            Console.WriteLine("\nDone! any key to exit...");
            Console.ReadKey();
        }
    }
}

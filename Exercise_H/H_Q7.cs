using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class H_Q7
    {
        public static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int rowA = A.GetLength(0);
            int colA = A.GetLength(1);
            int rowB = B.GetLength(0);
            int colB = B.GetLength(1);
            int[,] result;
            if (colA == rowB)
            {
                result = new int[rowA, colB];
                for (int i = 0; i < rowA; i++)
                {
                    for (int j = 0; j < colB; j++)
                    {
                        for (int k = 0; k < colA; k++)
                        {
                            result[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }
            }
            else
            {
                result = A;
                Console.WriteLine("Illegal input, please check!");
            }
            return result;
        }
    }
}

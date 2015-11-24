using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            int j = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        j++;
                        matrix[row, col] = j;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0)-1; row >= 0; row--)
                    {
                        j++;
                        matrix[row, col] = j;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

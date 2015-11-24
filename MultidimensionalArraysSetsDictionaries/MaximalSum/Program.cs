using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowsFromTheConsole = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowsFromTheConsole[col]);
                }
            }
            int bestSum = int.MinValue;
            int[,] matrixBestSum = new int[3,3];
            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        for (int bestRow = 0; bestRow < 3; bestRow++)
                        {
                            for (int bestCol = 0; bestCol < 3; bestCol++)
                            {
                                matrixBestSum[bestRow, bestCol] = matrix[row+bestRow, col+bestCol];
                            }
                        }
                    }
                }
            }
            Console.WriteLine(bestSum);
            Console.WriteLine();
            for (int row = 0; row <3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0,4}",matrixBestSum[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}

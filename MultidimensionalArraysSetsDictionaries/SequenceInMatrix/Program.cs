using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int rows = int.Parse(Console.ReadLine());
           int cols = int.Parse(Console.ReadLine());
           string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowsFromTheConsole = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsFromTheConsole[col];
                }
            }
            int longestSequence = 0;
            string bestElement = "";
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int count=SequenceCheck(matrix, row, col);
                    if(count>longestSequence)
                    {
                        longestSequence = count;
                        bestElement = ""+matrix[row, col];
                    }
                }
            }
            if(DiagonalCheck(matrix)>longestSequence)
            {
                longestSequence = DiagonalCheck(matrix);
                bestElement = matrix[0, 0];
            }
            for (int i = 0; i <= longestSequence; i++)
            {
                Console.Write("{0} ",bestElement);
            }
            Console.WriteLine();
        }
        static int SequenceCheck(string[,] matrix,int row, int col)
        {
            int count = 0;
            int bestCount=0;
            for (int i = row; i < matrix.GetLength(0)-1; i++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                    count++;
                else 
                {
                    break;
                }
            }
            if (count > bestCount)
                bestCount = count;
            count =0;
            for (int j = col; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                    count++;
                else
                {
                    if (count > bestCount)
                        bestCount = count;
                    break;
                }
            }
            return bestCount;
        }
        static int DiagonalCheck(string[,]matrix)
        {
            int count=0;
            string firstElement=matrix[0,0];
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (col == row)
                    {
                        if (matrix[row, col] == firstElement)
                            count++;
                        else break;
                    }
                }
            }
            return count;
        }
    }
}

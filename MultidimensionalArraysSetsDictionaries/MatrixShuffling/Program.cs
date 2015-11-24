using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
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
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            string[] inputComands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string comand = inputComands[0];
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            string[,]swapMatrix= new string[1,1];
            while(comand!="END")
            {
                if(comand=="swap"&&inputComands.Length==5)
                {
                    x1 = int.Parse(inputComands[1]);
                    y1 = int.Parse(inputComands[2]);
                    x2 = int.Parse(inputComands[3]);
                    y2 = int.Parse(inputComands[4]);
                    if (x1 < rows && x2 < rows && y1 < cols && y2 < cols)
                    {
                        swapMatrix[0, 0] = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = swapMatrix[0, 0];
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write("{0,4 }", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                        Console.WriteLine("Nekorektni danni:");
                }
                else
                    Console.WriteLine("Nekorektni danni. Opitaite otnovo:");
                inputComands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                comand = inputComands[0];
            }
        }
    }
}

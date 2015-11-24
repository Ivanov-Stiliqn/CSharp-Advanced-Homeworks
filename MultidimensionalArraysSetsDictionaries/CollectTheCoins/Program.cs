using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectTheCoins
{
    class Program
    {
        static int row;
        static int col;
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                board[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    board[i][j] = input[j];
                }
            }
            string comands = Console.ReadLine();
            int wall = 0;
            int coins = 0;
            row = 0;
            col = 0;
            int currentRow = 0;
            int currentCol = 0;
            for (int com = 0; com < comands.Length; com++)
            {
                char comand = comands[com];
                GameOn(comand);
                if (row > board.GetLength(0) || row < 0|| col<0 || col>board[row].Length)
                {
                    wall++;
                    row = currentRow;
                    col = currentCol;
                }
                else
                {
                    currentCol = col;
                    currentRow = row;
                    if (board[row][col] == '$')
                        coins++;
                }


            }
            Console.WriteLine("Coins colected: {0}",coins);
            Console.WriteLine("Walls hitted: {0}",wall);
        }
        static void GameOn(char command)
        {
            switch (command)
            {
                case 'V': row++;break;
                case '^': row--; break;
                case '>': col++;break;
                case '<': col--; break;
            }
        }
    }
}

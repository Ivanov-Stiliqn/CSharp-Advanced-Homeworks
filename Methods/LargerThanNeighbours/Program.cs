using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                IsLargerThanNeighbours(numbers, i);
            }
        }
        static void IsLargerThanNeighbours(int[]numbers,int a)
        {
            if (a == 0)
            {
                if (numbers[a] > numbers[a + 1])
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else if (a == numbers.Length - 1)
            {
                if (numbers[a] > numbers[a - 1])
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
            {
                if ((numbers[a] > numbers[a + 1]) && (numbers[a] > numbers[a - 1]))
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
        }
    }
}

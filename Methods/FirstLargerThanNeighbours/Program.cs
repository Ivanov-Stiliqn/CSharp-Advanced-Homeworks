using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 0, 1, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }
        static int GetIndexOfFirstElementLargerThanNeighbours(int[]numbers)
        {
            if (numbers[0] > numbers[1])
                return numbers[0];
            else
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    if ((numbers[i] > numbers[i + 1]) && (numbers[i] > numbers[i - 1]))
                    {
                        return numbers[i];
                    }
                }
            }
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                return numbers[numbers.Length - 1];
            else
                return -1;
        }
    }
}

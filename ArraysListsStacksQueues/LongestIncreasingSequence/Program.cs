using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
            List<int> output = new List<int>();
            List<int> sequence = new List<int>();
            int count = 0;
            int startSequence = 0;
            int maxCount = 0;
            int maxStartIndex = 0;
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (count == 0)
                    startSequence = i;
                if (numbers[i] <numbers[i + 1])
                    count++;
                else
                {
                    for (int j = 0; j <= count; j++)
                    {
                        Console.Write("{0} ",numbers[startSequence+j]);
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStartIndex = startSequence;
                    }
                    count = 0;
                    Console.WriteLine();
                    if (i == numbers.Count() - 2)
                    {
                        Console.WriteLine(numbers[numbers.Count - 1]);
                    }
                }
            }
            if(count!=0)
            {
                for (int j = 0; j <= count; j++)
                {
                    Console.Write("{0} ", numbers[startSequence + j]);
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStartIndex = startSequence;
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Longest: ");
            for (int m = 0; m <= maxCount; m++)
            {
                Console.Write("{0} ",numbers[maxStartIndex+m]);
            }
            Console.WriteLine();
        }
    }
}
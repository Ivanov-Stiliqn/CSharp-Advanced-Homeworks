using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
            Console.WriteLine("Max: {0}",Max(numbers));
            Console.WriteLine("Min: {0}", Min(numbers));
            Console.WriteLine("Avg: {0}", Avg(numbers));
            Console.WriteLine("Sum: {0}", Sum(numbers));
            Console.WriteLine("Product: {0}", Product(numbers));
        }
        static int Max(int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
        static int Min(int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            return min;
        }
        static int Avg(int[] numbers)
        {
            int avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }
            return avg / numbers.Length;
        }
        static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static int Product(int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            List<int>integers=new List<int>();
            List<double> decimals = new List<double>();
            foreach (var item in elements)
            {
                if((double.Parse(item)-Math.Ceiling(double.Parse(item)))==0)
                    integers.Add(Convert.ToInt32(Math.Ceiling(double.Parse(item))));
                else
                    decimals.Add(double.Parse(item));
            }
            Console.Write("[ ");
            integers.ForEach(i => Console.Write("{0} ", i));
            Console.Write("]");
            double min=integers.Min();
            double max=integers.Max();
            double sum=integers.Sum();
            double avg=integers.Average();
            Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:0.00}",min,max,sum,avg);
            Console.WriteLine();
            Console.Write("[ ");
            decimals.ForEach(j => Console.Write("{0} ", j));
            Console.Write("]");
            min = decimals.Min();
            max = decimals.Max();
            sum = decimals.Sum();
            avg = decimals.Average();
            Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", min, max, sum, avg);
            Console.WriteLine();
        }
    }
}

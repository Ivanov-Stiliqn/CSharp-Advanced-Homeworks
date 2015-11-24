using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsStacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string[] numbers = input.Split(' ');
            //List<int> output = new List<int>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    output.Add(int.Parse(numbers[i]));
            //}
            //output.Sort();
            //foreach (var item in output)
            //{
            //    Console.Write(item+" ");
            //}
            List<int>arr=Console.ReadLine().Split(' ').Select(p => Convert.ToInt32(p)).ToList();

            arr.Sort();
            arr.ForEach(i => Console.Write("{0} ", i));
        }
    }
}

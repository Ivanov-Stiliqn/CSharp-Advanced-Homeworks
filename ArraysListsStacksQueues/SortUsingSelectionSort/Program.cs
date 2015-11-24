using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortUsingSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(p=>int.Parse(p)).ToList();
            int max = 0;
            int swap = 0;
            for (int i = 0; i < arr.Count()-1; i++)
            {
                max = i;
                for (int j = i+1; j < arr.Count(); j++)
                {
                    if (arr[j] > arr[max])
                        max = j;
                }
                swap = arr[max];
                arr[max] = arr[i];
                arr[i] = swap;
            }
            arr.ForEach(i => Console.Write("{0} ", i));
        }
    }
}

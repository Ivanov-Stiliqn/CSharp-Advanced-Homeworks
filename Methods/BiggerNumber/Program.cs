using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            GetMax(num, num2);
        }
        static void GetMax(int a, int b)
        {
            Console.WriteLine(Math.Max(a, b));
        }
    }
}

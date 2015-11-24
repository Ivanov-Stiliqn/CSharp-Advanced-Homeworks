using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();
            string stringToFind = Console.ReadLine().ToUpper();
            int count = 0;
            for (int i = 0; i <= text.Length-stringToFind.Length; i++)
            {
                string subString = text.Substring(i, stringToFind.Length);
                if (subString == stringToFind)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}

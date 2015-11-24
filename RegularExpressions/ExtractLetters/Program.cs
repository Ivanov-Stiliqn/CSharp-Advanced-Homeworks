using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i++)
            {
                if(text[i]!=text[i-1])
                    Console.Write(text[i-1]);
            }
            Console.Write(text[text.Length-1]);
            Console.WriteLine();
        }
    }
}

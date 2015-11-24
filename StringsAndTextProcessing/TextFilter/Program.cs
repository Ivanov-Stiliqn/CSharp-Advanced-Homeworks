using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string midText = text;
            for (int i = 0; i < bannedWords.Length; i++)
            {
                string stars=new string('*',bannedWords[i].Length);
                string replaced= midText.Replace(bannedWords[i],stars);
                midText = replaced;
            }
            Console.WriteLine();
            Console.WriteLine(midText);

        }
    }
}

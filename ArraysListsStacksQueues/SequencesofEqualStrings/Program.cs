using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesofEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> output = new List<string>();
            List<int> repeats = new List<int>();
            string word = "";
            string word2="";
            int count = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                word = "" + input[i];
                if (!output.Contains(word))
                {
                    count = 0;
                    output.Add(word);
                    for (int j = 0; j < input.Count(); j++)
                    {
                        word2 = "" + input[j];
                        if (word == word2)
                            count++;
                    }
                    repeats.Add(count);
                }
            }
            for (int i = 0; i < output.Count(); i++)
            {
                for (int j = 0; j < repeats[i]; j++)
                {
                    Console.Write("{0 } ",output[i]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            StreamReader readerSearchWords = new StreamReader("../../words.txt");
            StreamWriter writer = new StreamWriter("../../result.txt");
            int count = 0;
            int i = 0;
            int match = 0;
            List<string> result = new List<string>();
            using (writer)
            {
                using (readerSearchWords)
                {
                    string wordsToSearch = readerSearchWords.ReadLine();
                    while (wordsToSearch != null)
                    {
                        StreamReader readerText = new StreamReader("../../text.txt");
                        using (readerText)
                        {
                            string line = readerText.ReadLine();
                            while (line != null)
                            {
                                while ((match = line.ToLower().IndexOf(wordsToSearch, i)) != -1)
                                {
                                    if((!char.IsLetter(line[match+wordsToSearch.Length])&&(!char.IsLetter(line[match-1]))))
                                    {
                                        count++;
                                    }
                                    i = match+1;
                                }
                                i = 0;
                                line = readerText.ReadLine();
                            }
                        }
                        result.Add(count + " " + wordsToSearch);
                        count = 0;
                        wordsToSearch =readerSearchWords.ReadLine();
                    }
                    result.Sort();
                    result.Reverse();
                    foreach (var item in result)
                    {
                        string[] output = item.Split(' ');
                        writer.WriteLine(output[1] + " - " + output[0]);
                    }
                }
            }
        }
    }
}


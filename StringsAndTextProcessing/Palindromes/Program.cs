using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[]{' ','.','!','?',':',';',','},StringSplitOptions.RemoveEmptyEntries).ToArray();
            SortedSet<string> palindromes=new SortedSet<string>();
            int flag=0;
            foreach (var word in text)
            {
                flag = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != word[word.Length-1 - i])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    palindromes.Add(word);
            }
            Console.WriteLine(string.Join(", ",palindromes));
        }
    }
}

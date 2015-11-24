using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceAtag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a href";
            Regex regex = new Regex(pattern);
            string replacement = "[URL href";
            string replacedText = regex.Replace(text,replacement);
            string replacement2 = "]";
            string pattern2 = @"\b>\b|\b>$";
            Regex regex2 = new Regex(pattern2);
            string secondReplacedText = regex2.Replace(replacedText, replacement2);
            string replacement3 = "[/URL]";
            string pattern3 = @"<\/a>";
            Regex regex3 = new Regex(pattern3);
            string finalText = regex3.Replace(secondReplacedText, replacement3);
            Console.WriteLine();
            Console.WriteLine(finalText);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phoneBook = new Dictionary<string,string>();
            string input=Console.ReadLine();
            while(input!="search")
            {
                string[] contact = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                phoneBook.Add(contact[0], contact[1]);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while(!String.IsNullOrEmpty(input))
            {
                if(phoneBook.ContainsKey(input))
                    Console.WriteLine("{0} -> {1}",input,phoneBook[input]);
                else
                    Console.WriteLine("Contact {0} doesn't exist.",input);
                input = Console.ReadLine();
            }
        }
    }
}

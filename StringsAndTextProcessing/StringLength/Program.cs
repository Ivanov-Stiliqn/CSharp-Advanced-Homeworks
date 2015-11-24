using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input.Length>20)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i]);
                }
                string stars = new string('*', (20 - input.Length));
                Console.Write(stars);
            }
            Console.WriteLine();
        }
    }
}

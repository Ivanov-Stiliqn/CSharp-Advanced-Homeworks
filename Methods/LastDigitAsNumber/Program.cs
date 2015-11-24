using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitAsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsNumber(num));
        }
        static string GetLastDigitAsNumber(int a)
        {
            int lastDigit= a%10;
            string word="";
            switch(lastDigit)
            {
                case 1 : word=""+"one";break;
                case 2 : word=""+"two";break;
                case 3 : word=""+"three";break;
                case 4 : word=""+"four";break;
                case 5 : word=""+"five";break;
                case 6 : word=""+"six";break;
                case 7 : word=""+"seven";break;
                case 8 : word=""+"eight";break;
                case 9 : word=""+"nine";break;
                default: Console.WriteLine("Nekorektni danni"); break;
            }
            return word;
        }
    }
}

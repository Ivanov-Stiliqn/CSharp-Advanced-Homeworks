using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberAndLetters = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            int number = 0;
            int firstLetter = 0;
            int lastLetter = 0;
            double sum=0;
            double totalSum = 0;
            foreach (var pair in numberAndLetters)
            {
                sum = 0;
                number = GetingNumber(pair);
                firstLetter = FirstLetter(pair);
                lastLetter = LastLetter(pair);
                if ((int)pair[0] > 90)
                    sum += number * firstLetter;
                else
                    sum += (double)number / firstLetter;
                if ((int)pair[pair.Length-1] > 90)
                    sum += lastLetter;
                else
                    sum -= lastLetter;
                totalSum += sum;
            }
            Console.WriteLine("{0:0.00}",totalSum);
        }
        static int GetingNumber(string numberAndLetters)
        {
            string numberAsString=String.Empty;
            for (int i = 1; i < numberAndLetters.Length-1; i++)
            {
                numberAsString += numberAndLetters[i];
            }
            int number = int.Parse(numberAsString);
            return number;
        }

        static int FirstLetter(string numberAndLetters)
        {
            char firstLetter = numberAndLetters[0];
            int indexOfLetter=0;
            if ((int)firstLetter > 90)
                indexOfLetter = (int)firstLetter - 96;
            else
                indexOfLetter = (int)firstLetter - 64;
            return indexOfLetter;
        }

        static int LastLetter(string numberAndLetters)
        {
            char firstLetter = numberAndLetters[numberAndLetters.Length-1];
            int indexOfLetter = 0;
            if ((int)firstLetter > 90)
                indexOfLetter = (int)firstLetter - 96;
            else
                indexOfLetter = (int)firstLetter - 64;
            return indexOfLetter;

        }
    }
}

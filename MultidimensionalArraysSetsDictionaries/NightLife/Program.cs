using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string city = "";
            string place = "";
            string performer = "";
            string input=Console.ReadLine();
            while(input!="End")
            {
                string[] data = input.Split(new char[] { ';' });
                city = data[0];
                place = data[1];
                performer = data[2];
                if (!nightLife.ContainsKey(city))
                {
                    nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!nightLife[city].ContainsKey(place))
                {
                    nightLife[city][place] = new SortedSet<string>();
                }
                nightLife[city][place].Add(performer);
                input = Console.ReadLine();
            }
            foreach (var cityPair in nightLife)
            {
                Console.WriteLine(cityPair.Key);
                foreach (var placePair in cityPair.Value)
                    Console.WriteLine("->{0}: {1}", placePair.Key, string.Join(",",placePair.Value));
            }
        }
    }
}

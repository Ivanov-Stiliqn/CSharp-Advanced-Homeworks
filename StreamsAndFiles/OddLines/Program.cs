using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../testFile.txt");
            using(reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while(line!=null)
                {
                    if(lineNumber%2!=0)
                    {
                        Console.WriteLine("Line {0} - {1}",lineNumber,line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

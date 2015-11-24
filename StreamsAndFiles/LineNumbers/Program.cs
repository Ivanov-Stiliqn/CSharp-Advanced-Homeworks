using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../testFile.txt");
            StreamWriter writer = new StreamWriter("../../newTestFile.txt");
            using(writer)
            {
                using(reader)
                {
                    int lineNumbers = 0;
                    string line =reader.ReadLine();
                    while(line!=null)
                    {
                        writer.WriteLine("{0}: {1}", lineNumbers, line);
                        lineNumbers++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

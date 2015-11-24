using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static string filePath = "../../cooldog.jpg";
        static string destination = "../../cooldog-copy.jpg";
        static void Main()
        {
            using (var file = new FileStream(filePath, FileMode.Open))
            {
                using (var copyFile = new FileStream(destination, FileMode.Create))
                {
                    byte[] buffer = new byte[600000];
                    while(true)
                    {
                        int readbytes = file.Read(buffer, 0, buffer.Length);
                        if(readbytes==0)
                        {
                            break;
                        }
                    }
                    copyFile.Write(buffer, 0, buffer.Length);
                }
            }

        }
    }
}

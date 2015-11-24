using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace SlicingFile
{
    class Program
    {
        static void Main()
        {
            string sourceFile = "C:/Users/AboveAll/Downloads/Montevideo, bog te video Prica prva (2010) DvDRiP/Montevideo.avi";
            string destinationDirectory = "C:/Users/AboveAll/Downloads/MontevideoParts";
            string destinationOnFullFile = "C:/Users/AboveAll/Downloads/MontevideoFullMovie/MontevideoFull.avi";
            int parts = int.Parse(Console.ReadLine());
            Slice(sourceFile, destinationDirectory, parts);
            List<string> partsPath = new List<string>(parts);
            for (int i = 0; i < parts; i++)
            {
                partsPath.Add("C:/Users/AboveAll/Downloads/MontevideoParts" + "/Part" + i + ".gz");
            }
            Assemble(partsPath, destinationOnFullFile);
        }
        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var file = new FileStream(sourceFile, FileMode.Open))
            {
                while (file.Position < file.Length)
                {
                    for (int i = 0; i < parts; i++)
                    {
                        using (var filePart = new FileStream(destinationDirectory + "/" + "Part" + i + ".gz", FileMode.Create))
                        {
                            using (GZipStream compression = new GZipStream(filePart, CompressionMode.Compress))
                            {
                                int chunk = 0;
                                while (chunk < file.Length / parts)
                                {
                                    int readbytes;
                                    byte[] buffer = new byte[file.Length / parts];
                                    readbytes = file.Read(buffer, 0, buffer.Length);
                                    if (readbytes == 0)
                                        break;
                                    chunk += readbytes;
                                    filePart.Write(buffer, 0, readbytes);

                                }
                            }
                        }
                    }
                }
            }
        }
        static void Assemble(List<string> files, string destinationDirectory)
        {
            for (int i = 0; i < files.Count; i++)
            {

                using (var filePart = new FileStream(files[i], FileMode.Open))
                {
                    int readbytes;
                    byte[] buffer = new byte[4096];
                    using (var fullFile = new FileStream(destinationDirectory, FileMode.Append))
                    {
                        using (GZipStream decopression = new GZipStream(filePart, CompressionMode.Decompress))
                        {
                            while (true)
                            {
                                readbytes = filePart.Read(buffer, 0, buffer.Length);
                                if (readbytes == 0)
                                    break;
                                fullFile.Write(buffer, 0, readbytes);
                            }
                        }
                    }
                }
            }
        }
    }
}

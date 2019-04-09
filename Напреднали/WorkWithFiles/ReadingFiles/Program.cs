using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingFiles
{
    class Startup
    {
        static void Main(string[] args)
        {
           using (var stream = new StreamReader(@"..\..\myText.txt", Encoding.UTF8))
            {
                Console.OutputEncoding = Encoding.UTF8;
                //var fileContent = stream.ReadToEnd();
                var line = stream.ReadLine();
                int i = 0;
                while (line != null)
                {
                    Console.WriteLine($"Line {i}: {line}");
                    i++;
                    line = stream.ReadLine();
                }
               // Console.WriteLine(fileContent);
            }
        }
    }
}

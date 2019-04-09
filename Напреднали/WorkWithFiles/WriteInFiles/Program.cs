using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteInFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"..\..\myText.txt";
            var encoding = Encoding.UTF8;
            var appendToFile = true;

            using(var writer = new StreamWriter(filename, appendToFile, encoding))
            {
                writer.WriteLine("123456");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var fs = File.Create("liveDemo.txt");
            fs.Write(new byte[] { 1, 2, 3, 4 }, 0, 3);
            fs.Flush();

            fs.Close();

            var fileName = @"..\..\neshto.txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
    }
}

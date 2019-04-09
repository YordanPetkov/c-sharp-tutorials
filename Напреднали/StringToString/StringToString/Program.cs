using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToString
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] formats = "D E C F X P".Split(' ');
            foreach (string f in formats)
            {
                Console.WriteLine("{0} - {1}", f, 3245.ToString(f));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "_,__  ,  ndsjka djasn      cask,    _ , ___ ";
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.TrimStart());
            Console.WriteLine(text.TrimEnd());
            Console.WriteLine(text.Trim('_', ' ', ','));
        }
    }
}

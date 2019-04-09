using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildingStrings
{
    class Startup
    {
        static StringBuilder Repeat(char c, int count)
        {
            StringBuilder result = new StringBuilder();

            while(count > 0)
            {
                result.AppendFormat("--{0}--",c);
                count--;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Repeat('*', 10));
        }
    }
}

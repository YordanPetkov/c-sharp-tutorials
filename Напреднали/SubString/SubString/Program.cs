using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    class Startup
    {
        static void Main(string[] args)
        {
            string text = "My strange , boring and long text.";

            string substr = text.Substring(2);
            string substr2 = text.Substring(2, 8);
            string substr3 = text.Substring(13,19 - 13); //From 13 to 19 index.
            Console.WriteLine(text);
            Console.WriteLine($"Substring(2) = {substr}");
            Console.WriteLine($"Substring(2,8) = {substr2}");
            Console.WriteLine($"Substring(13,19-13) = {substr3}");
        }
    }
}

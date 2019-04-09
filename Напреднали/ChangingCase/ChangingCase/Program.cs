using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingCase
{
    class Startup
    {
        static void Main(string[] args)
        {
            string str1 = "Strings are fun?!";
            string str2 = "ANOTHER STRING";
            string str3 = "WhERe IS MY PiZZa???";
            string str4 = "konStanTin";

            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str3.ToLower());

            string firstLetter = str4.Substring(0, 1).ToUpper();
            string rest = str4.Substring(1).ToLower();

            string ans = firstLetter + rest;
            Console.WriteLine(ans);


            char firstLetter2 = char.ToUpper(str4[0]);
            string rest2 = str4.Substring(1).ToLower();

            string ans2 = firstLetter2 + rest2;
            Console.WriteLine(ans2);
        }
    }
}

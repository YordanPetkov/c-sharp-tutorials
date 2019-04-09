using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultytaskDelegates
{
    public delegate void Print(string std);
    class MultyDelegates
    {
        static void PrintStr(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintUpperCase(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void PrintGreen(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Print p = PrintStr;
            p += PrintUpperCase;
            p += PrintGreen;

            p("Pesho");


            Print p2 = delegate (string str)
            {
                Console.WriteLine(str);
            };

            p2 += delegate (string str)
            {
                Console.WriteLine(str.ToUpper());
            };

            p2 += delegate (string str)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            };

            p2("tosho");
        }
    }
}

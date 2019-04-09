using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeDelegates
{
    delegate void PrintStuff(string stuff);

    class Program
    {
        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello from {name}");
        }

        static void Print2(string text)
        {
            Console.WriteLine($"---------- {text} -----------");
        }

        static void PrintGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void FindAndPrintNum(int[] numbers, PrintStuff print)
        {
            var max = numbers.Max();
            print(max.ToString());
        }

        static void Main(string[] args)
        {
            PrintStuff print = PrintHello;
            PrintStuff print2 = Print2;
            PrintStuff printGreen = PrintGreen;
            print("pesho");
            print2("Tosho");
            printGreen("Misho");

            var numbers = new int[] { 1, 2, -5, 20, 13, 15 };

            FindAndPrintNum(numbers, print);
            FindAndPrintNum(numbers, print2);
            FindAndPrintNum(numbers, printGreen);
        }
    }
}

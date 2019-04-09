using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isOdd = n => n % 2 != 0;
            Func<int, int, int> sum = (a, b) => a + b;
            Func<string, int> parse = int.Parse;

            Action<string> saveToFile = text => File.AppendAllText("./Gosho.txt", text + "\r\n");

            var words = new string[] { "kaun", "metla", "mi6ki", "petel" };

            foreach (var w in words)
            {
                saveToFile(w);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i} is odd : {isOdd(i)}.");
            }

            Console.WriteLine(sum(6,7));
            
        }
    }
}

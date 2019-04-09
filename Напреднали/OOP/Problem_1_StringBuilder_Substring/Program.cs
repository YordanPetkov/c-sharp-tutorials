using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_StringBuilder_Substring
{
    class Program
    { 
        static void Main(string[] args)
        {
            StringBuilder first = new StringBuilder("Hello my name is PESHO!");
            StringBuilder second = new StringBuilder();
            second = first.Substring(6, 10);

            Console.WriteLine(second);
        }
    }
}

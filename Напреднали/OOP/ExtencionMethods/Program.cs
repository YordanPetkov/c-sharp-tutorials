using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 5, 8, 11, 17 };

            numbers.IncrementAll();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }

    
}

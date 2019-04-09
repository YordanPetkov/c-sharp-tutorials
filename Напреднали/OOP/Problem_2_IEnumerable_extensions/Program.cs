using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_IEnumerable_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 7 };
            List<int> list = new List<int>(numbers);
            Console.WriteLine(list.Sum());

        }
    }
}

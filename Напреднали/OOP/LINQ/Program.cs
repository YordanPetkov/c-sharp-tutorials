using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var usualSuspects = new string[] {"pnbdsjbesho", "Pesho", "Tosho", "Godsho", "Shosho", "Kucheto Rex", "Stamat"};
            var shoshovci =
                from suspect in usualSuspects
                where suspect.EndsWith("sho") || suspect.Contains("Rex")
                orderby suspect.Length, suspect
                select $"Usual suspect called {suspect}";

            Console.WriteLine(string.Join("\r\n", shoshovci));

            var peshovchi = usualSuspects
                            .Where(name => name.EndsWith("sho") || name.Contains("Rex"))
                            .OrderBy(suspect => suspect.Length)
                            .ThenBy(suspect => suspect)
                            .Select(suspect => "Cyber criminal called " + suspect);
            Console.WriteLine(string.Join("\r\n", peshovchi));

            var numbers = new int[] { 1, 2, 10, 33, 68, 99 };

            var sum = numbers.Sum(x => x & 1);
            var max = numbers.Max(x => x % 19);

            Console.WriteLine(sum);
            Console.WriteLine(max);


            var n = Enumerable.Range(0, 10).ToArray();

            Console.WriteLine(string.Join(",", n));

            var random = new Random();

            var randNums = Enumerable.Range(0, 5).Select(x => random.Next());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Join(", ", numbers));
            }
        }
    }
}

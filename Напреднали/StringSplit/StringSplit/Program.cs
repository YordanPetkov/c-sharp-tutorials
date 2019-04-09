using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Startup
    {
        static void Main(string[] args)
        {
            string text = "Hello, my name is Yordan and " +
                "i like to programming on C#, JavaScript and PHP.";
            string[] strSpace = text.Split(' ');

            Console.WriteLine($"String split on ' ' are ");
            foreach (string word in strSpace)
            {
                Console.WriteLine(word);
            }

            string numbers = "1, 4, 3, 6, 5, 87, 3, 2, 1, 5";
            string[] nums = numbers.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach (string n in nums)
            {
                sum += int.Parse(n);
            }
            Console.WriteLine(numbers);
            Console.WriteLine(sum);

            //second solution

            Console.WriteLine(
                numbers.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum()
                );
        }
    }
}

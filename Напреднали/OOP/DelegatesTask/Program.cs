using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask
{
    delegate bool IntPredicate(int n);

    class Program
    {
        static int[] Filter(int[] numbers, IntPredicate predicate)
        {
            var list = new List<int>();

            foreach (var n in numbers)
            {
                if (predicate(n))
                {
                    list.Add(n);
                }
            }
            return list.ToArray();
        }

        static bool GreaterThan5(int value)
        {
            return value > 5;
        }

        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        static bool IsPrime(int value)
        {
            var upperBound = Math.Sqrt(value);
            var isPrime = true;
            var candidate = 2;

            while (candidate <= upperBound && isPrime)
            {
                isPrime = value % candidate != 0;
                candidate++;
            }

            return isPrime;

        }

        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 5, 20, 13, 15, 17, 33, 19, 35 };
            var greater = Filter(numbers, GreaterThan5);
            var even = Filter(numbers, IsEven);
            var prime = Filter(numbers, IsPrime);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", greater));
            Console.WriteLine(string.Join(", ", even));
            Console.WriteLine(string.Join(", ", prime));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    delegate bool IntPredicate<T>(T n);

    class Program
    {
        static IEnumerable<T> Filter<T>(IEnumerable<T> numbers, IntPredicate<T> predicate)
        {
            var list = new List<T>();

            foreach (var n in numbers)
            {
                if (predicate(n))
                {
                    list.Add(n);
                }
            }
            return list;
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
            var greater = Filter(numbers, value => value > 5);
            var even = Filter(numbers, value => value % 2 == 0);
            var prime = Filter(numbers, value =>
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
            });

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", greater));
            Console.WriteLine(string.Join(", ", even));
            Console.WriteLine(string.Join(", ", prime));


            var numbers2 = new int[] { 10, 1, 45, 2, 5, 7 };

            var odd = numbers.Where(n => n % 2 == 1).ToList();
            var evetySecond = numbers.Where((value, index) => index % 2 == 1).ToList();
            Console.WriteLine 
        }

    }
}

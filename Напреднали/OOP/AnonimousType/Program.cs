using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { X = 10, Y = 12 };
            object user = new { UserId = 12,
                Username = "gosho.pesho",
                Email = "pesho@gosho.tosho",
                SayHello = (Action)(() => Console.WriteLine("Hello"))
            };
            dynamic dog = new { Name = "Sharo", Age = 2 };

            var humans = new[]
            {
                new { Name = "Pesho", Age = 13},
                new { Name = "Tarzan", Age = 30},
                new { Name = "Ivan", Age = 19},
            };

            foreach (var human in humans)
            {
                Console.WriteLine(human.Name);
            }

            Console.WriteLine(point);
        }
    }
}

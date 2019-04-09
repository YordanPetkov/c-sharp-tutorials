using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    class Program
    {
        static void Main(string[] args)
        {
            int c,br = 0;
            int[] s = new int[1000];
            c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < c; i++)
            {
                if (s[i] > s[i - 1]) s[i] = s[i - 1];
                else
                {
                    br++;
                }
            }
            Console.WriteLine(br);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = 21;
            ushort years = 2019;
            uint days = 737526;
            ulong hours = 17700624;
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("There are {0} centuries , {1} years , {2} days and {3} hours.", century, years, days, hours);

            int[] numbers = new int[10];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            List<int> MyList = new List<int>() { 1, 2, 3, 4, 5 };
            MyList[2] = 100;
            foreach (int item in MyList)
            {
                Console.WriteLine(item);
            }

            MyList.Add(6);

            for (int i = 0; i < MyList.Count; i++)
            {
                Console.Write(MyList[i] + " ");
            }
            Console.WriteLine();

            MyList.Remove(5);
            MyList.RemoveAt(2);
            Console.WriteLine(string.Join(" ", MyList));
        }
    }
}

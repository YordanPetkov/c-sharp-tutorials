using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new GenericList<int>();

            nums.Add(4);
            nums.Add(5);
            nums.Add(1);
            nums.Add(7);
            nums.Print();

            var students = new GenericList<string>();

            students.Add("Ivan");
            students.Add("Penka");
            students.Add("Yordan");
            students.Add("Pencho");
            students.Print();

            var evenNums = new GenericList<int>();
            for (int i = 0; i <= 20; i+=2)
            {
                evenNums.Add(i);
            }
            evenNums.Print();

            evenNums.RemoveFirst(6);
            evenNums.RemoveAt(2);
            evenNums.Print();

            evenNums = evenNums + 10;
            evenNums -= 12;
            evenNums--;
            evenNums.Print();
            Console.WriteLine(evenNums);

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 ,9};
            evenNums += myArray;
            evenNums.Print();

            string numbers = evenNums.ToString();
            Console.WriteLine(numbers);

            var list = new GenericList<char>(100);
            for (int i = 0; i < 75; i++)
            {
                list.Add((char)i);
            }
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.ToString());

            Console.WriteLine(GenericList<int>.Compare(evenNums,nums));

            var myNewList = new GenericList<int>(20);

            for (int i = 0; i < 20; i++)
            {
                myNewList.Add(i % 2);
            }
            Console.WriteLine(myNewList.ToString());
            myNewList.RemoveAll(1);
            Console.WriteLine(myNewList.ToString());


        }
    }
}

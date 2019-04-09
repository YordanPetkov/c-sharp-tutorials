using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_First_before_last
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new {Name = "Pesho", Surname = "Ivanov"},
                new {Name = "Ivan", Surname = "Petrov"},
                new {Name = "Gosho", Surname = "Todorov"}
            };

            var uniqueStudents = students
                .Where(student => string.Compare(student.Name, student.Surname) == -1)
                .Select(student => student);

            Console.WriteLine(string.Join(", ", uniqueStudents));
        }
    }
}

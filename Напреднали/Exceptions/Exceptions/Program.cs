using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeExceptions
{
    class Program
    {
        static int ReadUserNumber()
        {
            int userAge = 0;
            string userName = Console.ReadLine();
            try
            {
                userAge = int.Parse(Console.ReadLine());
                Console.WriteLine($"You are {userAge} years old.");
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message + $" cause by user {userName}");
                //Console.WriteLine("You probably entered invalid value.");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Value too big!");
            }

            finally
            {
                Console.WriteLine("Some cleanup.");
            }
            return userAge;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(ReadUserNumber().ToString());
            Console.WriteLine("End of program.");
        }
    }
}

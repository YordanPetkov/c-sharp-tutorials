using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = Console.ReadLine();
            int i = 0;

            while (i >= 0 && i < instructions.Length)
            {
                byte P;
                if(instructions.ElementAt(i) == '^')
                {
                    Console.WriteLine("Jump , Jump DJ kommt at {0}!",
                        i);
                    return;
                }
                else
                {
                    P = byte.Parse(instructions.ElementAt(i).ToString());
                    if(P == 0)
                    {
                        Console.WriteLine("You are so drunk to go on after {0}!",
                            i);
                        return;
                    }
                    else if(P % 2 == 0)
                    {
                        i += P;
                    }
                    else
                    {
                        i -= P;
                    }
                }
            }
            Console.WriteLine("You are out of dancefield at {0}!",
                i);
        }
    }
}

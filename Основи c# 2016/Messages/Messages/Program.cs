using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string myMessage1 = Console.ReadLine();
            char oper = Char.Parse(Console.ReadLine());
            string myMessage2 = Console.ReadLine();

            if(oper == '-')
            {
                int ans = UnDecoding(myMessage1) - UnDecoding(myMessage2);
                Console.WriteLine(Decoding(ans));
            }
            else if(oper == '+')
            {
                int ans = UnDecoding(myMessage1) - UnDecoding(myMessage2);
                Console.WriteLine(Decoding(ans));
            }
        }

        static int UnDecoding(string message)
        {
            string unDecMessage = "";
            int intDigit = 0;
            for (int i = 0; i < message.Length; i += 3)
            {
                string stringDigit;
                
                stringDigit = message.Substring(i, 3);
                switch (stringDigit)
                {
                    case "cad" :
                        intDigit = 0;
                        break;
                    case "xoz":
                        intDigit = 1;
                        break;
                    case "nop":
                        intDigit = 2;
                        break;
                    case "cyk":
                        intDigit = 3;
                        break;
                    case "min":
                        intDigit = 4;
                        break;
                    case "mar":
                        intDigit = 5;
                        break;
                    case "kon":
                        intDigit = 6;
                        break;
                    case "iva":
                        intDigit = 7;
                        break;
                    case "ogi":
                        intDigit = 8;
                        break;
                    case "yan":
                        intDigit = 9;
                        break;
                    default:
                        break;
                }
                //intDigit = 1;
                unDecMessage += intDigit.ToString();
            }
            return int.Parse(unDecMessage);
        }


        static string Decoding(int num)
        {
            string decMessage = "";
            string myMessage = num.ToString();
            for (int i = 0; i < myMessage.Length; i++)
            {
                switch (myMessage[i] - '0')
                {
                    case 0:
                        decMessage += "cad";
                        break;
                    case 1:
                        decMessage += "xoz";
                        break;
                    case 2:
                        decMessage += "nop";
                        break;
                    case 3:
                        decMessage += "cyk";
                        break;
                    case 4:
                        decMessage += "min";
                        break;
                    case 5:
                        decMessage += "mar";
                        break;
                    case 6:
                        decMessage += "kon";
                        break;
                    case 7:
                        decMessage += "iva";
                        break;
                    case 8:
                        decMessage += "ogi";
                        break;
                    case 9:
                        decMessage += "yan";
                        break;
                    default:
                        break;
                }

            }
            return decMessage;
        }
        
    }
}

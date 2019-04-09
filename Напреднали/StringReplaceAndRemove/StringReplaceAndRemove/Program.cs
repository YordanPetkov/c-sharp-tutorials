using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplaceAndRemove
{
    class Startup
    {
        static void Main(string[] args)
        {
            string text = "This is gosho some text bla gosho text my text is css good nice.";

            Console.WriteLine(text);
            string newText = text.Replace("gosho", "serious buisness");
            Console.WriteLine(newText);


            string text2 = "This is actionscript and javascript and vbscript and script of course";
            Console.WriteLine(text2);
            string result = text2.Replace("actionscript", "pesho")
                                .Replace("javascript", "filiya")
                                .Replace("vbscript", "gosho")
                                .Replace("script", "kutiya")
                                .Replace('a','b');
            Console.WriteLine(result);

            string noVbscript = text2.Replace("vbscript", string.Empty);
            Console.WriteLine(noVbscript);

            string noVbScript2 = text2.Remove(17,10);
            Console.WriteLine(noVbScript2);
        }
    }
}

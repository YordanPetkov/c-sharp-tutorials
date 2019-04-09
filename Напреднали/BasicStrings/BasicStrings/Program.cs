using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class MethodStrings
    {
        static void Main(string[] args)
        {
            List<int> indeces = new List<int>();
            string sentence = "We like programming in C sharp " +
                "and programming in PHP" +
                "and programming in JavaScript!";
            string word1 = "programming";
            string word2 = "and";
            int middle = sentence.Length / 2;
            int index = sentence.IndexOf(word1,middle);
            Console.WriteLine($"Index of \"{word1}\" after index {middle} is {index}. ");

            Console.WriteLine($"All indeces of \"{word1}\" in\n \"{sentence}\" are : ");
            indeces = PrintAllIndices(sentence, word1);
            Console.WriteLine(String.Join(", ", indeces));

            Console.WriteLine(sentence.LastIndexOf(word2,middle));
        }

        static List<int> PrintAllIndices(string text, string searchValue)
        {
            List<int> indeces = new List<int>();
            int CurrentIndex = text.IndexOf(searchValue, 0);

            while(CurrentIndex != -1)
            {
                indeces.Add(CurrentIndex);
                CurrentIndex = text.IndexOf(searchValue, CurrentIndex + 1);
                
            }
            return indeces;
        }

    }
}

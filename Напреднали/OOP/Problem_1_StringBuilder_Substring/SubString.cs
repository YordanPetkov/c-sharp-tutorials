using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_StringBuilder_Substring
{
    static class SubString
    {
        public static StringBuilder Substring(this StringBuilder myStrBuild, int index, int length)
        {
            StringBuilder newString = new StringBuilder();
            int from = index;
            int to = length + index;
            for (int i = from; i < to; i++)
            {
                newString.Append(myStrBuild[i]);
            }
            return newString;
        }
    }
}

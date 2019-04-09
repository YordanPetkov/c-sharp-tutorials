using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethods
{
    static class ExtensionList
    {
        public static void IncrementAll(this List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]++;
            }
        }
    }
}

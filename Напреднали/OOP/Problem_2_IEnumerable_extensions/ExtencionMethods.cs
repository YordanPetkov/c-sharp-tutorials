using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_IEnumerable_extensions
{
    static class ExtencionMethods
    {
        public static int Sum<T>(this IEnumerable<T> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += int.Parse(item.ToString());
            }

            return sum;
        }

        
    }
}

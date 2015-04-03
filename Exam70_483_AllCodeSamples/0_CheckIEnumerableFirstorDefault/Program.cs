using System;
using System.Collections.Generic;
using System.Linq;

namespace _0_CheckIEnumerableFirstorDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            ages.Add(10);
            ages.Add(20);
            ages.Add(30);
            ages.Add(40);
            IEnumerable<int> age_IEnumerable = (IEnumerable<int>)ages;
            // Setting the default value to 1 after the query.
            int firstAge = age_IEnumerable.FirstOrDefault();
            Console.WriteLine(firstAge);

            List<int> agesEmpty = new List<int>();

            IEnumerable<int> agesEmpty_IEnumerable = (IEnumerable<int>)agesEmpty;
            // Setting the default value to 1 after the query.
            int firstAgeEmpty = agesEmpty_IEnumerable.FirstOrDefault();
            Console.WriteLine(firstAgeEmpty);
            Console.Read();
        }
    }
}

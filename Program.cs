using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkArrayListSort
{
    class Program
    {
        static void Main(string[] args)
        {
           IEnumerable<string>result = FilterOdds(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            foreach (var n in result) Console.WriteLine(n);
        }

        static IEnumerable<string>FilterOdds(int[] numbers)
        {
            var list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 != 0) list.Add(numbers[i]);

            return list
                .Select(n => n * -1)
                .Select(n => n.ToString()); 
        }

        /* static IEnumerable<string> OddNegativeStrings(int[] numbers)
         {
             var odds = numbers.Where(n => n % 2 != 0);
             var negative = odds.Select(n => n * -1);
             var strings = negative.Select(n => n.ToString());

             return strings.ToArray();
         }*/

        /*static int[] FilterOdds(int[] numbers)
        {
            var list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 != 0) list.Add(numbers[i]);

            return list.ToArray();
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfStrings
{
    static void Main()
    {
        var arrayOfStrings = Console.ReadLine()
            .Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            for (int sort = 0; sort < arrayOfStrings.Length - 1; sort++)
            {
                var first = arrayOfStrings[sort];
                var second = arrayOfStrings[sort + 1];

                if (first.CompareTo(second) > 0)
                {
                    arrayOfStrings[sort] = second;
                    arrayOfStrings[sort + 1] = first;
                }
            }

        }
        Console.WriteLine(string.Join(" ", arrayOfStrings));
    }
}


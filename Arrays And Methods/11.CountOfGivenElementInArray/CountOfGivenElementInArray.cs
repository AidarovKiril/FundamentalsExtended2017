using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfGivenElementInArray
{
    static void Main()
    {
        var arrayOfIntegers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var number = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
    }
}


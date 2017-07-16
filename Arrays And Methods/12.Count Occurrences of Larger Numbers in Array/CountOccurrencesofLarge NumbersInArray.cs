using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOccurrencesofLargeNumbesInArray
{
    static void Main()
    {
        var arrayOfRealNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

        var number = double.Parse(Console.ReadLine());
        var count = 0;

        for (int i = 0; i < arrayOfRealNumbers.Length; i++)
        {
            if (arrayOfRealNumbers[i] > number)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}


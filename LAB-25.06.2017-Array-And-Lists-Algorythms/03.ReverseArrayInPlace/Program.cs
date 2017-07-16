using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var array = Console.ReadLine()
          .Split()
          .Select(int.Parse)
          .ToArray();

        for (int arrIndex = 0; arrIndex < array.Length / 2; arrIndex++)
        {
            int temp = array[arrIndex];
            array[arrIndex] = array[(array.Length - 1) - arrIndex];
            array[(array.Length - 1) - arrIndex] = temp;
        }
        Console.WriteLine(string.Join(" ", array));

    }
}


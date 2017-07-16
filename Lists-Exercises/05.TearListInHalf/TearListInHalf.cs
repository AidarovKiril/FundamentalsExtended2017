﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TearListInHalf
{
    static void Main()
    {
        var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        TearListInHalfOutput(numbers);

    }

    static void TearListInHalfOutput(List<int> numbers)
    {
        var firstList = new List<int>();
        var secondList = new List<int>();

        var len = numbers.Count;

        for (int i = 0; i < len; i++)
        {
            if (i < (len / 2))
            {
                firstList.Add(numbers[i]);
            }
            else
            {
                secondList.Add(numbers[i]);
            }
        }

        ResultOutput(firstList, secondList);
    }

    static void ResultOutput(List<int> firstList, List<int> secondList)
    {
        var result = new List<int>();

        for (int i = 0; i < firstList.Count; i++)
        {
            var firstDigit = secondList[i] / 10;
            var secondDigit = secondList[i] % 10;

            result.Add(firstDigit);
            result.Add(firstList[i]);
            result.Add(secondDigit);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}


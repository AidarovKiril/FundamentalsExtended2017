﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

        var result = new List<string>();

        for (int i = 0; i < input.Count; i++)
        {
            if (i % 2 == 1)
            {
                result.Add(input[i]);
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}


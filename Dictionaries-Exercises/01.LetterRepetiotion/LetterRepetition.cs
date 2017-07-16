using System;
using System.Collections.Generic;
using System.Linq;

class LetterRepetition
{
    static void Main()
    {
        char[] chars = Console.ReadLine()
                .ToCharArray();

        Dictionary<char, int> result = new Dictionary<char, int>();

        foreach (var ch in chars)
        {
            if (!result.ContainsKey(ch))
            {
                result[ch] = 0;
            }
            result[ch]++;
        }

        foreach (var ch in result)
        {
            Console.WriteLine($"{ch.Key} -> {ch.Value}");
        }
    }
}


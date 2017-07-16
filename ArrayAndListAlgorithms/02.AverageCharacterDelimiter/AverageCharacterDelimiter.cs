using System;
using System.Collections.Generic;
using System.Linq;
class AverageCharacterDelimiter
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        var charаcterCounter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            var inputAsChar = input[i].ToCharArray();
            foreach (var element in inputAsChar)
            {
                sum += element;
                charаcterCounter++;
            }

        }
        char average = Convert.ToChar(sum / charаcterCounter);
        var delimeter = average.ToString().ToUpper();

        Console.WriteLine(string.Join($"{delimeter}", input));
    }
}


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var stringArray = Console.ReadLine()
                 .ToCharArray();
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        ModifiedOtput(stringArray, numbers);
    }

    static void ModifiedOtput(char[] stringArray, int[] numbers)
    {
        var len = stringArray.Length;
        var answer = string.Empty;

        for (int i = 0; i < len; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                var result = Math.Abs(numbers[i] - stringArray[i]);
                answer += (char)result;
            }
            else if (numbers[i] % 2 != 0)
            {
                var result = Math.Abs(numbers[i] + stringArray[i]);
                answer += (char)result;
            }
        }
        Console.WriteLine(answer);
    }
}



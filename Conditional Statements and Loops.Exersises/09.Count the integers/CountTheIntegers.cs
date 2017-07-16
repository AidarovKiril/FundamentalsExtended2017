using System;

class CountTheIntegers
{
    static void Main()
    {
        int count = 0;
        int number;
        bool result = true;
        while (result)
        {
            result = int.TryParse(Console.ReadLine(), out number);
            if (result) count++;
        }
        Console.WriteLine(count);
    }
}


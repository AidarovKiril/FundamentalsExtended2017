using System;

class MagicLetter
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char invalidChar = char.Parse(Console.ReadLine());

        for (char i = firstChar; i <= secondChar; i++)
        {
            if (i == invalidChar)
            {
                continue;
            }
            for (char j = firstChar; j <= secondChar; j++)
            {
                if (j == invalidChar)
                {
                    continue;
                }
                for (char k = firstChar; k <= secondChar; k++)
                {
                    if (k == invalidChar)
                    {
                        continue;
                    }
                    Console.Write($"{i}{j}{k} ");
                }
            }
        }
    }
}


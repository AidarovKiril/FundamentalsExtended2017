using System;

class CypherRoulette
{
    static void Main()
    {
        int wordsCount = int.Parse(Console.ReadLine());
        string message = string.Empty;
        string previousWord = string.Empty;
        bool toEnd = true;
        for (int i = 0; i < wordsCount; i++)
        {
            string currentWord = Console.ReadLine();
            if (currentWord == "spin")
            {
                toEnd = !toEnd;
                i--;
            }
            switch (toEnd)
            {
                case (true): message += currentWord; break;
                case (false): message = currentWord + message; break;
            }
            if (currentWord == previousWord)
            {
                message = string.Empty;
                if (currentWord == "spin")
                {
                    toEnd = !toEnd; 
                }
                previousWord = currentWord;
            }

            previousWord = currentWord;
        }
        message = message.Replace("spin", string.Empty);
        Console.WriteLine(message);
    }
}


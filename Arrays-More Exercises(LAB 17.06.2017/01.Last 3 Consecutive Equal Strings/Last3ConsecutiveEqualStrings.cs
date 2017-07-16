using System;
using System.Linq;


class Last3ConsecutiveEqualStrings
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();
        int counterOfEqualStrings = 1;

        for (int cntr = words.Length - 1; cntr > 0; cntr--)
        {
            if (words[cntr] == words[cntr - 1])
            {
                counterOfEqualStrings++;
                if (counterOfEqualStrings == 3)
                {
                    Console.WriteLine("{0} {0} {0}", words[cntr]);
                    break;
                }
            }
            else
            {
                counterOfEqualStrings = 1;
            }
        }
    }
}

     



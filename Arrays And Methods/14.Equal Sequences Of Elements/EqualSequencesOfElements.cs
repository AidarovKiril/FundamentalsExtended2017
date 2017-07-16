using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EqualSequencesOfElements
{
    static void Main()
    {
        var arrayOfElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var len = arrayOfElements.Length;
        var isTrue = false;

        for (int i = 0; i < len - 1; i++)
        {
            if (arrayOfElements[i] == arrayOfElements[i + 1])
            {
                isTrue = true;
            }
            else
            {
                break;
            }
        }
        if (isTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

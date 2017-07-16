using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class ArraySymmetry
{
    static void Main()
    {
        var arrayOfStrigs = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        var len = arrayOfStrigs.Length;
        bool isTrue = false;

        for (int i = 0; i <= len - 1; i++)
        {
            string first = arrayOfStrigs[i];
            string second = arrayOfStrigs[len - 1 - i];

            if (first == second)
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


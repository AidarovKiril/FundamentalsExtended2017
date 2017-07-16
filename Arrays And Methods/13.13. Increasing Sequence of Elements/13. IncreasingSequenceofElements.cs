using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncreasungSequenseOfElements
{
    static void Main()
    {
        var arrayOfElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var len = arrayOfElements.Length;
        bool isTrue = false;

        for (int i = 0; i < len - 1; i++)
        {
            if (arrayOfElements[i] <= arrayOfElements[i + 1])
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
                break;
            }
        }
        if (isTrue == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

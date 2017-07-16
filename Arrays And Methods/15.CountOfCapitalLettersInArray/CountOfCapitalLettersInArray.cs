using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfCapitalLettersInArray
{
    static void Main()
    {
        var arrayOfStringElements = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        var len = arrayOfStringElements.Length;
        var count = 0;

        for (int i = 0; i < len; i++)
        {
            try
            {
                char chars = char.Parse(arrayOfStringElements[i]);
                if (chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }
            catch (Exception)
            {
            }
        }
        Console.WriteLine(count);
    }
}


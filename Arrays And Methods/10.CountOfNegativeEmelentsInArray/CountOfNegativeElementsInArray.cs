using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfNegativeElementsInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arrayOfIntegers = new int[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            arrayOfIntegers[i] = int.Parse(Console.ReadLine());

            if (arrayOfIntegers[i] < 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}


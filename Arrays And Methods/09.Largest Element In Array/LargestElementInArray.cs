using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestElementInArray
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int biggestElement = int.MinValue;
        int[] arrayOfIntegers = new int[number];

        for (int i = 0; i < number; i++)
        {
            arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            if (biggestElement < arrayOfIntegers[i])
            {
                biggestElement = arrayOfIntegers[i];
            }
        }
        Console.WriteLine(biggestElement);
    }
}


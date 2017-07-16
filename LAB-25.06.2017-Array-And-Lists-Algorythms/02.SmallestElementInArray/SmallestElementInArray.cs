using System;
using System.Collections.Generic;
using System.Linq;

class SmallestElementInArray
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int minElement = int.MaxValue;

        for (int index = 0; index < elements.Count; index++)
        {
            if (elements[index] < minElement)
            {
                minElement = elements[index];
                
            }
        }
        Console.WriteLine(minElement);
    }
}


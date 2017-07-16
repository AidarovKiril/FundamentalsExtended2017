using System;
using System.Collections.Generic;
using System.Linq;



class ArrayContainsElement
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int number = int.Parse(Console.ReadLine());

        for (int index = 0; index < elements.Count; index++)
        {
            int containedNumber = 0;
            if (number == elements[index])
            {
                containedNumber = number;
                Console.WriteLine("yes");
                return;
            }
           
        }
        Console.WriteLine("no");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


class DistinctList
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

        foreach (var element in elements.Distinct())
        {
            Console.Write(element + " ");
        }
        
    }
}

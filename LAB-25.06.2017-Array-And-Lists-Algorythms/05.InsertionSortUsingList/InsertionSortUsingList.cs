using System;
using System.Collections.Generic;
using System.Linq;

class InsertionSortUsingList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        numbers.Sort();       

        Console.WriteLine(string.Join(" ", numbers));
    }
}


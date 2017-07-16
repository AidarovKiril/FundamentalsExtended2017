using System;
using System.Collections.Generic;
using System.Linq;
{
class Program
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
        InsertionSort();
        Console.WriteLine(string.Join(" ", elements));
    }
    static void InsertionSort()
}


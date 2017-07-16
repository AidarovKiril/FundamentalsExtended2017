using System;
using System.Collections.Generic;
using System.Linq;



class IntegerInsertion
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input = Console.ReadLine();

        while (input != "end")
        {
            int insertIndex = int.Parse(input[0].ToString());
            int number = int.Parse(input);
            numbers.Insert(insertIndex, number);
            input = Console.ReadLine();
        }


        Console.WriteLine(string.Join(" ", numbers));
    }
}


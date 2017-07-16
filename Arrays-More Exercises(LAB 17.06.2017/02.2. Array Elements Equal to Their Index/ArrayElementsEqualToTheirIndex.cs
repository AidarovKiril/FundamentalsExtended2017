using System;
using System.Linq;



class ArrayElementsEqualToTheirIndex
{
    static void Main()
    {
       var digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == i)
            {
                Console.Write($"{digits[i]} ");
            }
        }
        Console.WriteLine();
    }
}


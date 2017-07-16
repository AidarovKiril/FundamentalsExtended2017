using System;

class IntervalOfNumbers
{
    static void Main()
    {     


        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());


        for (int i = Math.Min(number1, number2); i <= Math.Max(number1, number2); i++)
        {
            Console.WriteLine(i);
        }
    }
}


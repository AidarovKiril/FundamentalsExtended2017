using System;

class CaloriesCounter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ingredient = string.Empty;
        int calories = 0;
        for (int i = 0; i < n; i++)
        {
            ingredient = Console.ReadLine().ToLower();
            if (ingredient == "tomato sauce")
            { calories = calories + 150; }
            if (ingredient == "cheese")
            { calories = calories + 500; }
            if (ingredient == "salami")
            { calories = calories + 600; }
            if (ingredient == "pepper")
            { calories = calories + 50; }
        }
        Console.WriteLine("Total calories: " + calories);
    }
}


using System;

class Cakeingredientedients
{
    static void Main()
    {
        string ingredient = null;
        for (int i = 0; ; i++)
        {
            ingredient = Console.ReadLine();
            if (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            else
            {
                Console.WriteLine($"Preparing cake with {i} ingredients.");
                break;
            }
        }
    }
}

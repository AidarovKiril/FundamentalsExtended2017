using System;

class ChooseADrink2
{
    static void Main()
    {
        string profession = Console.ReadLine();        
        int quantity = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        decimal waterPrice = 0.70m;
        decimal cofeePrice = 1.00m;
        decimal beerPrice = 1.70m;
        decimal teaPrice = 1.20m;

        if ((profession == "Athlete"))
        {
            totalPrice = 0.70m * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
        else if (profession == "SoftUni Student" )
        {
            totalPrice = 1.70m * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
        else if ((profession == "Businessman") || (profession == "Businesswoman"))
        {
            totalPrice = 1.00m * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
        else
        {
            totalPrice = 1.20m * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}


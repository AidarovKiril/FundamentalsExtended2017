using System;

class ChooseADrink
{
    static void Main()
    {
        string profession = Console.ReadLine();
        var drink = "";

        if (profession == "Athlete")
        {
            drink = "Water";
            
        }
        else if ((profession == "Businessman") || (profession == "Businesswoman"))
        {
            drink = "Coffee";
           
        }
        else if (profession == "SoftUni Student")
        {
            drink = "Beer";
            
        }
        else
        {
            drink = "Tea";
            
        }
        Console.WriteLine("{0}", drink);       
    }       
    
}


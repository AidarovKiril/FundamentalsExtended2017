using System;

class TravelingAtTheLightSpeed
{
    static void Main()
    {
        decimal kmForLightYear = 9450000000000m;
        decimal speedOfLight = 300000;
        decimal lightYears = decimal.Parse(Console.ReadLine());

        decimal secondsTotal = (lightYears * kmForLightYear) / speedOfLight;
        int minutes = (int)(secondsTotal / 60);
        secondsTotal %= 60;
        int hours = minutes / 60;
        minutes %= 60;
        int days = hours / 24;
        hours %= 24;
        int weeks = days / 7;
        days %= 7;

        Console.WriteLine("{0} weeks", weeks);
        Console.WriteLine("{0} days", days);
        Console.WriteLine("{0} hours", hours);
        Console.WriteLine("{0} minutes", minutes);
        Console.WriteLine("{0} seconds", Math.Round(secondsTotal));


    }
}


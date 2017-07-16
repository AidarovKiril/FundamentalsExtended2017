using System;

class DistanceOfTheStars
{
    static void Main()
    {
        decimal kmForOneLightYear = 9450000000000m;
        decimal proximaCentauriDistance = kmForOneLightYear * 4.22m;
        decimal centerOfTheGalaxyDistance = kmForOneLightYear * 26000m;
        decimal milkyWayDiameterDistance = kmForOneLightYear * 100000m;
        decimal edgeOfTheUniverseDistance = kmForOneLightYear * 46500000000m;

        Console.WriteLine("{0:e2}", proximaCentauriDistance);
        Console.WriteLine("{0:e2}", centerOfTheGalaxyDistance);
        Console.WriteLine("{0:e2}", milkyWayDiameterDistance);
        Console.WriteLine("{0:e2}", edgeOfTheUniverseDistance);

    }
}


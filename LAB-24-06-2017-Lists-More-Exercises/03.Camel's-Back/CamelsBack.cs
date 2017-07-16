using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CamelsBack
{
    static void Main()
    {
        List<int> buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
        int camelsBack = int.Parse(Console.ReadLine());

        if (buildings.Count <= camelsBack)
        {
            Console.WriteLine("already stable: " + string.Join(" ", buildings));
        }
        else
        {
            var rounds = (buildings.Count - camelsBack) / 2;


            buildings = buildings
                .Skip(rounds)
                .Take(camelsBack)
                .ToList();

            Console.WriteLine($"{rounds} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
        }
    }
}


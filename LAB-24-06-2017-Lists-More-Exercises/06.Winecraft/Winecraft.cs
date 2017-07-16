using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Winecraft
{
    static void Main()
    {
        List<int> grapes = Console.ReadLine().Split().Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        // dokato jivoto grozde > n
        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                BloomGrapes(grapes);
            }
            
        }
    }
    static void BloomGrapes(List<int> grapes)
    {

    }
    static void HealWeakGrapes(List<int> grapes, int treshhold)
    {

    }
}


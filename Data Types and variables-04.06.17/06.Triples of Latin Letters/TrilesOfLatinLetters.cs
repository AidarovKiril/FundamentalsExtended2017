using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class TrilesOfLatinLetters
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int cnt1 = 0; cnt1 < 3; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < 3; cnt2++)
                {
                    for (int cnt3 = 0; cnt3 < 3; cnt3++)
                    {
                        Console.WriteLine("" + (char)(cnt1));
                    }
                }
            }
        }
    }
}

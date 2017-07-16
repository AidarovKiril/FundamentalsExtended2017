using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class NthDigit
    {
         static int FindNthDigit(long number, int index)
        {
            int currentIndex = 1;
            while (number > 0)
            {
                if (currentIndex == index)
                {
                    number %= 10;
                    break;
                }
                else
                {
                    number /= 10;
                }
                currentIndex++;
            }
            return currentIndex;
        }    

        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int result = FindNthDigit(number, index);
            Console.WriteLine(result);

        }
    }
}

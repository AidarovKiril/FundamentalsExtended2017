using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интержалс
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());


            for (int i = Math.Min(number1, number2); i <= Math.Max(number1, number2); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Linq;

class Altitude
{
    
        static void Main(string[] args)
        {
            string[] flight = Console.ReadLine().Split().ToArray();

            long height = long.Parse(flight[0]);
            string lastword = string.Empty;


            for (long i = 1; i < flight.Length; i++)
            {



                if (flight[i] == "up")
                {
                    height += 0;
                    lastword = "up";
                    continue;
                }
                if (flight[i] == "down")
                {
                    height -= 0;
                    lastword = "down";
                    continue;
                }

                if (flight[i] != "up" && flight[i] != "down" && lastword == "up")
                {
                    height += long.Parse(flight[i]);
                }
                if (flight[i] != "down" && flight[i] != "up" && lastword == "down")

                {
                    height -= long.Parse(flight[i]);

                }

            }
            if (height <= 0)
            {
                Console.WriteLine("crashed");

            }
            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", height);
            }
        }
    }



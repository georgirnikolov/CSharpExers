using System;

namespace pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerOfPoke = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int powerAfterPoke = powerOfPoke;
            int counter = 0;

            while (powerAfterPoke >= distance)
            {
                powerAfterPoke -= distance;
                counter++;

                if (powerAfterPoke == powerOfPoke * 0.5)
                {
                    if (exhaustion != 0)
                    {
                        powerAfterPoke /= exhaustion;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(powerAfterPoke);
            Console.WriteLine(counter);
        }
    }
}

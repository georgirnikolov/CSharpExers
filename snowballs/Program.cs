using System;
using System.Numerics;

namespace snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowballSnow;
            int snowballTime;
            int snowballQuality;

            string output = "";

            BigInteger snowballValue = new BigInteger();
            BigInteger bestValue = new BigInteger();

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestValue)
                {
                    bestValue = snowballValue;
                    output = $"{snowballSnow} : {snowballTime} = {bestValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(output);
        }
    }
}

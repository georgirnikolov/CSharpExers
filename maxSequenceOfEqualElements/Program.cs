using System;
using System.Linq;
using System.Collections.Generic;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            
            long maxSequence = 0;
            long maxLength = 0;
            long length = 0;

            for (int numberCheck = 1; numberCheck < inputNumbers.Count; numberCheck++)
            {

                if (inputNumbers[numberCheck] == inputNumbers[numberCheck - 1])
                {
                    length++;

                    if (length > maxLength)
                    {
                        maxSequence = inputNumbers[numberCheck];
                        maxLength++;
                    }

                }
                else
                {
                    length = 0;
                }
            }

            for (int i = 0; i <= maxLength; i++)
            {
                //TODO: ask why it fails to give 100, but only gives 85/100
                Console.Write($"{maxSequence} ");
            }
        }
    }
}

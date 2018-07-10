using System;
using System.Collections.Generic;
using System.Linq;

namespace pokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int indexRemove;
            int removedIndex = 0;
            int swap;

            while (input.Any())
            {
                indexRemove = int.Parse(Console.ReadLine());

                if (indexRemove < 0)
                {
                    removedIndex = input[0];
                    input[0] = input.Last();
                    sum += removedIndex;
                }
                else if (indexRemove > input.Count - 1)
                {
                    removedIndex = input.Last();
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                    sum += removedIndex;
                }
                else
                {
                    removedIndex = input[indexRemove];
                    input.RemoveAt(indexRemove);
                    sum += removedIndex;
                }

                for (int index = 0; index < input.Count; index++)
                {
                    if (input[index] <= removedIndex)
                    {
                        input[index] += removedIndex;
                    }
                    else if (input[index] > removedIndex)
                    {
                        input[index] -= removedIndex;
                    }
                }
            }


            Console.WriteLine(sum);

        }
    }
}

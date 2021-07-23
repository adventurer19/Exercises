using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int BestSequenceSize = 0;
            int bestIndex = 0;
            int bestSequenceSum = 0;
            int[] bestarray = new int[size];
            int bestsample = 1;
            int sample = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Clone them!") break;
                int[] array = line.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sequenceSum = 0;
                sample++;
                foreach (var item in array)
                {
                    sequenceSum += item;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    int cNumber = array[i];
                    if (cNumber == 0) continue;
                    int currentSequenceSize = 1;
                    for (int k = i + 1; k < array.Length; k++)
                    {
                        if (cNumber == array[k])
                        { currentSequenceSize++; }
                        else { break; }
                    }
                    if (BestSequenceSize < currentSequenceSize)
                    {
                        bestIndex = i;
                        BestSequenceSize = currentSequenceSize;
                        bestarray = array;
                        bestSequenceSum = sequenceSum;
                        bestsample = sample;
                    }
                    else if (BestSequenceSize == currentSequenceSize)
                    {
                        if (i < bestIndex)
                        {
                            bestSequenceSum = sequenceSum;
                            bestIndex = i;
                            BestSequenceSize = currentSequenceSize;
                            bestarray = array;
                            bestsample = sample;
                        }
                        else if (i == bestIndex && bestSequenceSum < sequenceSum)
                        {

                            {
                                bestSequenceSum = sequenceSum;
                                bestIndex = i;
                                BestSequenceSize = currentSequenceSize;
                                bestarray = array;
                                bestsample = sample;
                            }



                        }
                    }

                }
            }
            Console.WriteLine($"Best DNA sample {bestsample} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{string.Join(' ', bestarray)}");

        }
    }
}
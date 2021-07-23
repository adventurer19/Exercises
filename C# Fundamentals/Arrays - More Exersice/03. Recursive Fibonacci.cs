using System;
using System.Linq;

namespace _321
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftCounterOfFirstArray = (initialArray.Length / 4) - 1;
            int counterOfSecondArray = (initialArray.Length / 4);
            int rightCounterOfFirstArray = 1;
            int size = initialArray.Length / 2;
            int[] first = new int[size];
            int[] second = new int[size];
            for (int i = 0; i < first.Length; i++)
            {
                if (i < first.Length / 2)
                {
                    first[i] = initialArray[leftCounterOfFirstArray];
                    leftCounterOfFirstArray--;
                }
                else
                {
                    first[i] = initialArray[initialArray.Length - rightCounterOfFirstArray];
                    rightCounterOfFirstArray++;
                }
            }
            //Console.WriteLine(string.Join(' ',first));
            for (int k = 0; k < second.Length; k++)
            {

                second[k] = initialArray[counterOfSecondArray];
                counterOfSecondArray++;
            }
            //Console.WriteLine(string.Join(' ', second));

            int[] result = new int[size];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = first[i] + second[i];
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
using System;
using System.Linq;

namespace _321
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] outputArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                string array = Console.ReadLine();
                int[] chars = new int[array.Length];
                string lowerCase = array.ToLower();
                for (int k = 0; k < array.Length; k++)
                {
                    bool operation = false;
                    switch (lowerCase[k])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            operation = true;
                            break;
                        default:
                            operation = false;
                            break;
                    }
                    chars[k] = Convert.ToInt32(array[k]);
                    if (operation)
                    {
                        sum += chars[k] * array.Length;
                    }
                    else
                    {
                        sum += chars[k] / array.Length;
                    }


                }
                outputArray[i] = sum;
            }
            Array.Sort(outputArray);
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }


        }
    }
}
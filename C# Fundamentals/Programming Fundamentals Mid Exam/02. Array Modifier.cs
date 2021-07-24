using System;
using System.Linq;


namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght = nums.Length;
            if (lenght < 2) return;
            string line = String.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] parts = line.Split(' ').ToArray();
                if (parts[0] == "swap")
                {
                    int idxOne = int.Parse(parts[1]);
                    int idxTwo = int.Parse(parts[2]);

                    if (Exceptions(idxOne, idxTwo, lenght)) continue;
                    else
                    {
                        int currenrt = nums[idxOne];
                        nums[idxOne] = nums[idxTwo];
                        nums[idxTwo] = currenrt;
                    }
                }
                else if (parts[0] == "multiply")
                {
                    int idxOne = int.Parse(parts[1]);
                    int idxTwo = int.Parse(parts[2]);

                    if (Exceptions(idxOne, idxTwo, lenght)) continue;
                    else
                    {
                        nums[idxOne] *= nums[idxTwo];
                    }
                }
                else if (parts[0] == "decrease")
                {

                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] -= 1;
                    }

                }

            }

            Console.WriteLine(string.Join(", ", nums));



        }

        private static bool Exceptions(int idxOne, int idxTwo, int lenght)
        {
            bool Iexit = false;
            if (idxOne < 0 || idxTwo < 0 || idxOne > lenght - 1 || idxTwo > lenght - 1)
            {
                Iexit = true;
            }

            return Iexit;
        }
    }
}
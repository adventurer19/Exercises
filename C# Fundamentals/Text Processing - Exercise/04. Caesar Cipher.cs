using System;
using System.Linq;
using System.Text;

namespace Project
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] ex = input.ToCharArray();
            for (int i = 0; i < ex.Length; i++)
            {
                ex[i] = Convert.ToChar(ex[i] + 3);
            }
            input = new string(ex);
            Console.WriteLine(input);

        }

    }

}
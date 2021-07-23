using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issue8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddsum = 0;
            int evensum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {

                    evensum += number;
                }
                else if (1 % 2 != 0)
                {

                    oddsum += number;
                }
            }

            if (evensum == oddsum)
            {
                Console.WriteLine("Yes Sum =" + oddsum);
            }
            else if (evensum != oddsum)
            {
                Console.WriteLine("No diff={0}", Math.Abs(oddsum - evensum));
            }
        }
    }
}
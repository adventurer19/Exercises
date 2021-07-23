using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            pwdValidator(line);


        }

        private static void pwdValidator(string line)
        {

            bool isTrue = false;
            int digitCounter = 0;
            foreach (char letter in line)
            {
                int x = Convert.ToInt32(letter);
                if ((x >= 65 && x <= 90) ||
                    (x >= 97 && x <= 122))
                {
                    isTrue = true;
                }
                else if ((x >= 48 && x <= 57))
                {
                    digitCounter++;
                    isTrue = true;
                }
                else

                {
                    isTrue = false;
                    break;
                }


            }

            if (line.Length < 6 || line.Length > 10) Console.WriteLine("Password must be between 6 and 10 characters");
            if (!isTrue) Console.WriteLine("Password must consist only of letters and digits");
            if (digitCounter < 2) Console.WriteLine("Password must have at least 2 digits");
            if (digitCounter >= 2 && isTrue && (line.Length >= 6 || line.Length <= 10))
            {
                Console.WriteLine("Password is valid");
            }



        }
    }
}
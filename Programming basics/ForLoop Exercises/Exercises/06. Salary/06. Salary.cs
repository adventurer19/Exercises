using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salara = int.Parse(Console.ReadLine());
            int moneytaken = 0;
            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                switch (text)
                {
                    case "Facebook":
                        moneytaken += 150;
                        break;
                    case "Instagram":
                        moneytaken += 100;
                        break;
                    case "Reddit":
                        moneytaken += 50;
                        break;

                }
                if (moneytaken >= salara)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;

                }
            }
            //if (moneytaken >= salara)

            // 

            if (moneytaken < salara)
            {
                Console.WriteLine(salara - moneytaken);
            }

        }

    }

}
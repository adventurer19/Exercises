using System;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string command = Console.ReadLine();
        double sum = 0;

        while (command != "Start")
        {
            double num = double.Parse(command);
            if (num == 0.1 || num == 0.2 || num == 0.5 || num == 1 || num == 2)
            {
                sum += num;
            }
            else
            {
                Console.WriteLine($"Cannot accept {num}");
            }
            command = Console.ReadLine();

        }
        string text = Console.ReadLine();

        while (text != "End")
        {
            double productPrice = 0;

            if (text == "Nuts")
            {
                productPrice = 2;

            }
            else if (text == "Water")
            {
                productPrice = 0.7;
            }
            else if (text == "Crisps")
            {
                productPrice = 1.5;
            }
            else if (text == "Soda")
            {
                productPrice = 0.8;
            }
            else if (text == "Coke")
            {
                productPrice = 1.0;
            }
            if (productPrice != 0)
            {
                if (productPrice <= sum)
                {
                    sum -= productPrice;
                    Console.WriteLine("Purchased {0}", text.ToLower());

                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine($"Invalid product");
            }

            text = Console.ReadLine();
        }
        Console.WriteLine($"Change: {sum:f2}");



    }
}
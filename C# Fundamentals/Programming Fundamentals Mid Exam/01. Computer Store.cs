using System;
using System.Threading.Channels;


namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            double taxes = 0;
            double summ = 0;
            while (line != "regular" && line != "special")
            {
                double priceNoTax = double.Parse(line);
                if (priceNoTax < 0)
                {
                    Console.WriteLine("Invalid price!");

                }
                else
                {
                    summ += priceNoTax;
                    taxes += priceNoTax * 0.2;
                }

                line = Console.ReadLine();
            }

            double total = taxes + summ;
            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (line == "special") total -= total * 0.1;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {summ:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {total:f2}$");






        }

    }
}
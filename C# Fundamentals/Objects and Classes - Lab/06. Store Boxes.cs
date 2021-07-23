using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Items
    {
        public string Name { get; set; }

        public double Price { get; set; }

    }

    class Box
    {

        public string SerialNumber { get; set; }


        public Items Items { get; set; } // тука ти е грешката имаш пропърти от променливата ти итем
        // след като си направиш клас този клас го третираш като тип данни както стринг инт и т.н само  тука  си създал тип данни 
        // Items i променливата се казва Итемс >> тоест имаш тип данни итемс и променлива итемс >>
        // аналогично ако имаш стринг стрингс >>>> в твоя случай  итемс итемс ;

        public double ItemQuantity { get; set; }

        public double PriceForABox { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> box = new List<Box>();
            List<Items> itemsList = new List<Items>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] order = input.Split();

                string serialNumber = order[0]; // сериалномер на кутуията 
                string nameProduct = order[1]; // името на предмета 
                double qunatity = double.Parse(order[2]); // количество предмети // тука беше объркал номерата на индексите
                double price = double.Parse(order[3]); // цена на предмета 
                double priceOfbox = qunatity * price; // цена на кутията
                Items CurrItem = new Items() //  не си инициализирал предмета , създал си рецептата ама тортата обаче защо няма торта ?
                {
                    Name = nameProduct,
                    Price = price
                };
                Box CurrBox = new Box()

                {
                    SerialNumber = serialNumber,
                    Items = CurrItem,// тука не си създал правилно рецептата за кутията, върни се отгоре на рецептата Class box()
                    ItemQuantity = qunatity,
                    PriceForABox = priceOfbox,
                };

                box.Add(CurrBox);
            }

            var fullItem = box.OrderByDescending(x => x.PriceForABox).ToList(); // тука беше забравил 
            // да го кастнеш към лист с .tolist();

            foreach (var IdxBook in fullItem)
            {
                //  тука погледни първо 59 ред ако не си ,след като си погледнал рецептата на кутията сега можеш да изкараш 
                // пропъртито итемс в което имаш вложени още две пропъртита име и  цена !
                Console.WriteLine(IdxBook.SerialNumber);
                Console.WriteLine($"-- {IdxBook.Items.Name} - ${IdxBook.Items.Price:f2}: {IdxBook.ItemQuantity}");
                Console.WriteLine($"-- ${IdxBook.PriceForABox:f2}");
            }
        }
    }
}
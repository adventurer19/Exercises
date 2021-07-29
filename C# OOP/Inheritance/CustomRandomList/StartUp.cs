using System;
using CustomRandomList;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList()
            {
                 "Rufus", "Bear", "Dakota", "Fido",
                    "Vanya", "Samuel", "Koani", "Volodya",
                    "Prince", "Yiska"

            };
            string removed = list.RandomString();
            Console.WriteLine(removed);
            Console.WriteLine($"{string.Join(' ',list)}");

        }
    }
}

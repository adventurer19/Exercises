using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var reptile = new Reptile("niki");
            Console.WriteLine(reptile.Name);
        }
    }
}
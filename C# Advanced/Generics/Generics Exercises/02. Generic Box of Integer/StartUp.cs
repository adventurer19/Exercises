using System;

namespace Generics
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine();
                var box = new Box<int>(int.Parse(line));
                Console.WriteLine(box);
            }

            
        }
    }
}

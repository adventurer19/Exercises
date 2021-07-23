using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var firstText = Console.ReadLine();
            var secondText = Console.ReadLine();
            var result = GetMax(type, firstText, secondText);
            Console.WriteLine(result);
        }   //Може и така: Console.WriteLine(GetMax(type, firstText, secondText));, но при
        //положение, че не ми e нужна променливата result някъде в кода! В този случай нямам нужда от result.
        private static string GetMax(string type, string firstText, string secondText)
        {
            var result1 = 0;
            var result2 = 0;
            if (type == "int")
            {
                result1 = int.Parse(firstText);
                result2 = int.Parse(secondText);
            }
            else if (type == "char")
            {
                result1 = char.Parse(firstText);
                result2 = char.Parse(secondText);
            }
            else if (type == "string")
            {
                int comparison = firstText.CompareTo(secondText);    //Сравнение на string като числова стойност(ASCII)!
                if (comparison > 0)                            //Ако firstText > secondText, comparison = 1, иначе е -1!
                {
                    return firstText;
                }
                else
                {
                    return secondText;
                }
            }
            if (result1 > result2)
            {
                return firstText;
            }
            else
            {
                return secondText;
            }
        }
    }
}
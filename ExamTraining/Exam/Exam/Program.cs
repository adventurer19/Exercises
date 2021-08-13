using System;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var input = string.Empty;
            while ((input=Console.ReadLine())!= "Generate")
            {
                var cmd = input.Split(">>>").ToArray();
                switch (cmd[0])
                {
                    case "Contains":
                        if (text.Contains(cmd[1]))
                        {
                            Console.WriteLine($"{text} contains {cmd[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case"Flip":
                        int x = int.Parse(cmd[2]);
                        int y = int.Parse(cmd[3]);
                        var substring = text.Substring(x,y-x);
                        switch (cmd[1])
                        {
                            case "Upper":
                                text = text.Replace(substring,substring.ToUpper());
                                break;

                            case "Lower":
                                text = text.Replace(substring,substring.ToLower());

                                break;
                        }
                        Console.WriteLine(text);
                        break;
                    case "Slice":
                        int a = int.Parse(cmd[1]);
                        int b = int.Parse(cmd[2]);
                        text = text.Remove(a, b-a);
                        Console.WriteLine(text);
                        break;
                }

            }

            string result = $"Your activation key is: {text}";
            Console.WriteLine(result);
        }
    }
}

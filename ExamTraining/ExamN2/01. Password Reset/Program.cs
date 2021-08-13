using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            var pws = Console.ReadLine();
            var line = string.Empty;
            while ((line = Console.ReadLine()) != "Done")
            {
                var cmd = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "TakeOdd":
                        pws = TakeOdd(pws);
                        Console.WriteLine(pws);
                        break;

                    case "Cut":
                        var index = int.Parse(cmd[1]);
                        var length = int.Parse(cmd[2]);
                        pws = pws.Remove(index, length);
                        Console.WriteLine(pws);
                        break;
                    case "Substitute":
                        var substringValue = cmd[1];
                        var substitute = cmd[2];
                        if (!pws.Contains(substringValue))
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            pws = pws.Replace(substringValue, substitute);
                            Console.WriteLine(pws);
                        }
                        break;

                }
            }

            Console.WriteLine($"Your password is: {pws}");
        }

        private static string TakeOdd(string pws)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pws.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(pws[i]);
                }
            }

            return sb.ToString();
        }
    }
}

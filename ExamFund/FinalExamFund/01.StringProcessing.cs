using System;
using System.Linq;
using System.Text;

namespace examfund
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            string line = String.Empty;
            while ((line = Console.ReadLine()) != "Complete")
            {
                var cmd = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "Make":
                        switch (cmd[1])
                        {
                            case "Upper":
                                email = email.ToUpper();
                                Console.WriteLine(email);
                                break;
                            case "Lower":
                                email = email.ToLower();
                                Console.WriteLine(email);
                                break;
                        }
                        break;
                    case "GetDomain":
                        int count = int.Parse(cmd[1]);
                        if (count >= 0 && count <= email.Length - 1)
                        {
                            string substring = email.Substring(email.Length - count);
                            Console.WriteLine(substring);
                        }
                        break;
                    case "GetUsername":
                        if (email.Contains('@'))
                        {
                            int index = email.IndexOf('@');
                            var subText = email.Substring(0, index);
                            Console.WriteLine(subText);
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;
                    case "Replace":
                        email = email.Replace(cmd[1], "-");
                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        string result = Encrypt(email);
                        Console.WriteLine(result);
                        break;
                }
            }


        }

        private static string Encrypt(string email)
        {
            var charArr = email.ToCharArray();
            var array = charArr.Select(x => Convert.ToInt32(x)).ToArray();
            return string.Join(' ', array);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace text_proc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = TextMorse(input);
            Console.WriteLine(output);
        }

        public static string TextMorse(string aInput)
        {
            string[] words = aInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder result = new StringBuilder();
            var morseBook = new Dictionary<string, char>
            {
                {"/",' '},
                {".-",'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E'},
                {"..-.",'F'},
                {"--.",'G'},
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'},
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'},
                {"---",'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S'},
                {"-",'T'},
                {"..-",'U'},
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'},
                {".----",'1'},
                {"..---",'2'},
                {"...--",'3'},
                {"....-",'4'},
                {".....",'5'},
                {"-....",'6'},
                {"--...",'7'},
                {"---..",'8'},
                {"----.",'9'},
                {"-----",'0'}

            };
            foreach (var idx in words)
            {
                if (idx == "|")
                    result.Append(' ');
                else if (morseBook.ContainsKey(idx))
                {
                    result.Append(morseBook[idx]);
                }
            }
            return result.ToString();
        }
    }
}
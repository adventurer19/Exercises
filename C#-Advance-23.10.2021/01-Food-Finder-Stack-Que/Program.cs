using System;
using System.Collections.Generic;
using System.Linq;

namespace stacks
{
    class Program
    {

        static void Main(string[] args)
        {

            var words = new string[] { "pear", "flour", "pork", "olive" };

            // reading the input ,malko klynki ama sym zabravil sintaksa,  chetesh konzolata,pravish masiv ot charove i posle  
            // mahash white spaces i celiq  list go slagash na steka i na opashkata 


            var lineOne = Console.ReadLine().ToCharArray();
            var listOne = CharList(lineOne);
            var lineTwo = Console.ReadLine().ToCharArray();
            var listTwo = CharList(lineTwo);
            Queue<char> rowOne = new Queue<char>(listOne);
            Stack<char> rowTwo = new Stack<char>(listTwo);


            // tyka v toq list subiram vsickhki bukvi koito imat suvpadeniq
            var allMatchChars = new List<char>();

            while (rowTwo.Count > 0)
            {
                var firstChar = rowOne.Dequeue();
                rowOne.Enqueue(firstChar);
                var secondChar = rowTwo.Pop();
                // vurtq v cikala s vsichki dumi

                for (int i = 0; i < words.Length; i++)
                {

                    var item = words[i];
                    // vurtq v dumata vsichki bukvi
                    for (int j = 0; j < item.Length; j++)
                    {
                        // dobavqm namereniq chat v lista ot 28 red 
                        if (item[j] == firstChar)
                        {
                            
                            allMatchChars.Add(firstChar);

                        }
                        if (item[j] == secondChar)
                        {
                            allMatchChars.Add(secondChar);

                        }


                    }

                }

            }
            // inicializiram list kadeto da zapazvam vsichki namereni bukvi
            var listOfFoundWords = new List<string>();
            //vartq vsichki dumi
            foreach (var word in words)
            {
                var count = 0;
                foreach (char letters in word)
                {
                    // vartq bukvi i proverqvam dali ima suvpadenie s bukvite ot lista 
                    // ako ima suvpaenie counta  e ++ ;
                    if(allMatchChars.Contains(letters))
                    {
                        count++;
                    }
                }
                // ako counta e po malyk ot word.len znachi nqma syvpadenie
                // ako e raven ima suvpadenie
                if(count==word.Length)
                {
                    listOfFoundWords.Add(word);

                }


            }
            // tfa e outputa
            Console.WriteLine($"Words found: {listOfFoundWords.Count}");
            foreach (var item in listOfFoundWords)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();

        }

        // tfa e metod koito mi maha whitespaces ot array
        public static List<char> CharList(char[] array)
        {

            var list = new List<char>();
            foreach (var item in array)
            {
                if (item != ' ')
                {
                    list.Add(item);
                }

            }
            return list;


        }
    }
}

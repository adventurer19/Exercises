using System;

namespace exam
{

    class Program
    {

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            var rowBee = -1;
            var colBee = -1;
            var matrix = new char[x, x];
            var points = 0;
            var winWithPoints = false;
            for (int i = 0; i < x; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int y = 0; y < x; y++)
                {
                    matrix[i, y] = line[y];
                    var currentChar = line[y];
                    if (currentChar == 'B')
                    {
                        rowBee = i;
                        colBee = y;
                    }

                }
            }
            var cmd = Console.ReadLine();
            while (cmd != "End")
            {

                var a = -1;
                var b = -1;
                switch (cmd)
                {
                    case "up":
                        a = rowBee - 1;
                        b = colBee;
                        break;

                    case "down":
                        a = rowBee + 1;
                        b = colBee;
                        break;

                    case "left":
                        a = rowBee;
                        b = colBee - 1;
                        break;

                    case "right":
                        a = rowBee;
                        b = colBee + 1;
                        break;


                }
              
                try
                {
                    var nextMove = matrix[a, b];
                    matrix[rowBee,colBee] = '.';
                    if (nextMove == 'f')
                    {
                        points++;
                        matrix[a, b] = 'B';


                    }
                    else if (nextMove == 'O')
                    {
                        matrix[a, b] = '.';
                        if (cmd == "up")
                        {
                            a--;
                        }
                        else if (cmd == "down")
                        {
                            a++;
                        }
                        else if (cmd == "right")
                        {
                            b++;
                        }
                        else if (cmd == "left")
                        {
                            b--;
                        }

                        if (matrix[a, b] == 'f') points++;


                    }
                    matrix[a, b] = 'B';

                    rowBee = a;
                    colBee = b;

                }
                catch (IndexOutOfRangeException ex)
                {
                    matrix[rowBee,colBee] = '.';
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                if (points >= 5) winWithPoints = true;


                cmd = Console.ReadLine();
            }
           
            if (!winWithPoints)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - points} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {points} flowers!");
            }

            Print(matrix);

        }
        public static void Print(char[,]matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i,k]);
                }
                Console.WriteLine();
            }

        }
        
    }
}

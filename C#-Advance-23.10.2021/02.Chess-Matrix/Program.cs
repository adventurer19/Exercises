using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing the field
            var map = new string[8, 8];

            for (int i = 0, x = 8; i < 8; x--, i++)
            {
                var letter = 'a';

                for (int j = 0; j < 8; j++)
                {

                    map[i, j] = $"{Convert.ToChar(letter + j)}{x}";

                }


            }
            var mx = new char[8, 8];
            var wRow = -1;
            var wCol = -1;
            var bRow = -1;
            var bCol = -1;


            for (int i = 0; i < 8; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    mx[i, j] = line[j];
                    if (line[j] == 'w')
                    {
                        wRow = i;
                        wCol = j;
                    }
                    else if (line[j] == 'b')
                    {
                        bRow = i;
                        bCol = j;
                    }
                }

            }



            while (true)
            {
                if (wRow == 0)
                {
                    var winningSpot = map[wRow, wCol];
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {winningSpot}.");
                    break;
                }
                else if (bRow == 7)
                {
                    var winningSpot = map[bRow, bCol];
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {winningSpot}.");
                    break;
                }

                if(wCol-1<0)
                {
                    var nextRight = mx[wRow - 1, wCol + 1];
                    if(nextRight=='b')
                    {
                           var spot = map[bRow, bCol];
                        Console.WriteLine($"Game over! White capture on {spot}.");
                        break;
                    }

                }
                if(wCol+1>8)
                {
                    var nextLeft = mx[wRow - 1, wCol - 1];
                    if (nextLeft == 'b')
                    {
                           var spot = map[bRow, bCol];
                        Console.WriteLine($"Game over! White capture on {spot}.");
                        break;
                    }
                }
                mx[wRow, wCol] = '-';
                mx[wRow - 1, wCol] = 'w';
                wRow--;
                if (bCol - 1 < 0)
                {
                    var nextRight = mx[bRow + 1, bCol + 1];
                    if (nextRight == 'w')
                    {
                        var spot = map[wRow, wCol];
                        Console.WriteLine($"Game over! Black capture on {spot}.");
                        break;
                    }

                }
                if (bCol + 1 > 8)
                {
                    var nextLeft = mx[bRow + 1, bCol - 1];
                    if (nextLeft == 'w')
                    {
                        var spot = map[wRow, wCol];
                        Console.WriteLine($"Game over! Black capture on {spot}.");
                        break;
                    }
                }
                mx[bRow, bCol] = '-';
                mx[bRow+1, bCol] = 'b';
                bRow++;













            }

            // print metodi za pomosht 
            //PrintTwo(map);

        }

        //public static void PrintTwo(string[,] mx)
        //{
        //    for (int i = 0; i < 8; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            Console.Write(mx[i, j]);
        //        }
        //        Console.WriteLine();


        //    }


            //}
            //public static void Print(char[,]mx)
            //{
            //    for (int i = 0; i < 8; i++)
            //    {
            //        for (int j = 0; j < 8; j++)
            //        {
            //            Console.Write(mx[i,j]);
            //        }
            //        Console.WriteLine();

            //    }


            //}
        
    }

}

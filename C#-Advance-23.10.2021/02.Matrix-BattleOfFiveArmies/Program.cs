using System;

namespace battleMx
{
    class Program
    {
        static void Main(string[] args)
        {

            var armorPoints = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());
            // read firstline 
            var line = Console.ReadLine().ToCharArray();
            // ini matrix with sizes dimension and line.length;
            var mx = new char[rows, line.Length];

            var positionRow = -1;
            var positionCol = -1;

            for (int i = 0; i < rows; i++)
            {   
                
                for (int j = 0; j < line.Length; j++)
                {
                    mx[i, j] = line[j];
                   
                    if(line[j]=='A')
                    {
                        positionRow = i;
                        positionCol = j;
                    }
                }
                // if checking zaradi parviq red koito chetem otgore izvun for loopa
                if (i == rows - 1) break;
                line = Console.ReadLine().ToCharArray();
            }
            var input = Console.ReadLine();
            while (true)
            {
                var cmd = input.Split();
                var cm = cmd[0];
                var row = int.Parse(cmd[1]);
                var col = int.Parse(cmd[2]);
                var nextRow = -1;
                var nextCol = -1;

                /// spawn Issue
                   if(row==positionRow && col==positionCol)
                   {
                        armorPoints -=2;
                        if(armorPoints<=0)
                        {
                            mx[positionRow, positionCol] = 'X';
                            Console.WriteLine($"The army was defeated at {positionRow};{positionCol}.");
                            break;
                        }
                   }
                   else
                   {
                        mx[row, col] = 'O';

                   }
                   ///
                if (cm=="up")
                {
                    nextRow = positionRow - 1;
                    nextCol = positionCol;
                }
                else if(cm=="down")
                {
                    nextRow = positionRow + 1;
                    nextCol = positionCol;
                }
                else if(cm=="left")
                {
                    nextRow = positionRow;
                    nextCol = positionCol - 1;
                }
                else if(cm=="right")
                {
                    nextRow = positionRow;
                    nextCol = positionCol + 1;
                }
                try
                {
                    var nextCell = mx[nextRow, nextCol];
                    mx[positionRow, positionCol] = '-';
                    if(nextCell=='M')
                    {
                        mx[nextRow, nextCol] = '-';
                        armorPoints -=1;
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armorPoints}");
                        break;
                    }
                    else if(nextCell=='O')
                    {
                        armorPoints -=3;

                        if (armorPoints <= 0)
                        {
                            mx[nextRow, nextCol] = 'X';
                            Console.WriteLine($"The army was defeated at {nextRow};{nextCol}.");
                            break;
                        }
                    
                    }
                    else if(nextCell=='-')
                    {
                        armorPoints--;
                    }
                    mx[nextRow, nextCol] = 'A';
                    positionRow = nextRow;
                    positionCol = nextCol;
                    if (armorPoints<=0)
                    {
                        mx[nextRow, nextCol] = 'X';
                        Console.WriteLine($"The army was defeated at {positionRow};{positionCol}.");
                        break;
                    }

                }
                catch (IndexOutOfRangeException e)
                {
                    armorPoints--;
                    if (armorPoints <= 0)
                    {
                        mx[positionRow, positionCol] = 'X';
                        Console.WriteLine($"The army was defeated at {positionRow};{positionCol}.");
                        break;
                    }

                }
              
                input = Console.ReadLine();

            }
       
            Print(mx);

        }


        public static void Print(char[,]mx)
        {
            for (int i = 0; i < mx.GetLength(0); i++)
            {
                for (int k = 0; k < mx.GetLength(1); k++)
                {
                    Console.Write(mx[i, k]);
                }
                Console.WriteLine();

            }
        }
    }
}

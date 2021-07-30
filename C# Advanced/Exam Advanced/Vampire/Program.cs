using System;
using System.Collections.Generic;
using System.Linq;

namespace Vampire
{
    class Player
    {
        public Player()
        {
            rowStart = -1;
            colStart = -1;
            IdxBunny = new List<int[]>();
        }
        public int rowStart { get; set; }
        public int  colStart { get; set; }
        public List<int[]>  IdxBunny { get; set; }
        public bool Dead { get; set; }

      
    }
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new char[num[0], num[1]];
            var player = new Player();
            bool isWin = false;
            var one = -1;
            var two = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                    if (matrix[i, j] == 'P')
                    {
                        player.rowStart = i;
                        player.colStart = j;
                    }
                    else if (matrix[i, j] == 'B')
                    {
                        var idxs = new int[] {i, j};
                        player.IdxBunny.Add(idxs);
                    }
                }
            }

            var path = Console.ReadLine().ToCharArray();
            for (int i = 0; i < path.Length; i++)
            {
                var move = path[i];
                var nextRow = -1;
                var nextCol = -1;
                if (move == 'U')
                {
                    nextRow = player.rowStart - 1;
                    nextCol = player.colStart;
                    if (!isOutside(nextRow, nextCol, matrix))
                    {
                        matrix[player.rowStart, player.colStart] = '.';
                        isWin = true;
                    }
                    else if (matrix[nextRow, nextCol] == 'B')
                    {
                        player.Dead = true;
                        one = nextRow;
                        two = nextCol;
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                        SpawnBunny(matrix, player);
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == '.')
                    {
                        matrix[player.rowStart, player.colStart] = '.';
                        matrix[nextRow, nextCol] = 'P';
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                    }
                    SpawnBunny(matrix,player);
                    if (player.Dead)
                    {
                        one = nextRow;
                        two = nextCol;
                        break;
                    }
                }
                else if (move == 'D')
                {
                    nextRow = player.rowStart + 1;
                    nextCol = player.colStart;
                    if (!isOutside(nextRow, nextCol, matrix))
                    {
                        matrix[player.rowStart, player.colStart] = '.';

                        isWin = true;
                    }
                    else if (matrix[nextRow, nextCol] == 'B')
                    {
                        one = nextRow;
                        two = nextCol;
                        player.Dead = true;
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                        SpawnBunny(matrix, player);
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == '.')
                    {
                        matrix[player.rowStart, player.colStart] = '.';
                        matrix[nextRow, nextCol] = 'P';
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                    }
                    SpawnBunny(matrix, player);
                    if (player.Dead)
                    {
                        one = nextRow;
                        two = nextCol;
                        break;
                    }

                }
                else if (move == 'R')
                {
                    nextRow = player.rowStart;
                    nextCol = player.colStart+1;
                    if (!isOutside(nextRow, nextCol, matrix))
                    {
                        matrix[player.rowStart, player.colStart] = '.';

                        isWin = true;
                    }
                    else if (matrix[nextRow, nextCol] == 'B')
                    {
                        one = nextRow;
                        two = nextCol;
                        player.Dead = true;
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                        SpawnBunny(matrix, player);
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == '.')
                    {
                        matrix[player.rowStart, player.colStart] = '.';
                        matrix[nextRow, nextCol] = 'P';
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                    }
                    SpawnBunny(matrix, player);
                    if (player.Dead)
                    {
                        one = nextRow;
                        two = nextCol;
                        break;
                    }
                }
                else if (move == 'L')
                {
                    nextRow = player.rowStart;
                    nextCol = player.colStart-1;
                    if (!isOutside(nextRow, nextCol, matrix))
                    {
                        matrix[player.rowStart, player.colStart] = '.';

                        isWin = true;
                    }
                    else if (matrix[nextRow, nextCol] == 'B')
                    {
                        one = nextRow;
                        two = nextCol;
                        player.Dead = true;
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                        SpawnBunny(matrix, player);
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == '.')
                    {
                        matrix[player.rowStart, player.colStart] = '.';
                        matrix[nextRow, nextCol] = 'P';
                        player.rowStart = nextRow;
                        player.colStart = nextCol;
                    }
                    SpawnBunny(matrix, player);
                    if (player.Dead)
                    {
                        one = nextRow;
                        two = nextCol;
                        break;
                    }
                }
                
                Print(matrix);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                if (player.Dead ||isWin)
                    break;
            }
            Print(matrix);

            if (isWin)
            {
                Console.WriteLine($"won: {player.rowStart} {player.colStart}");
            }
            else if(player.Dead)
            {
                Console.WriteLine($"dead: {one} {two}");
            }
            
        }

        private static bool isOutside(int nextRow, int nextCol, char[,] matrix)
        {
            bool isValid = nextRow >= 0 && nextRow < matrix.GetLength(0) &&
                           nextCol >= 0 && nextCol < matrix.GetLength(1);
            return isValid;
        }

        private static void SpawnBunny(char[,] matrix,Player Player)
        {
            foreach (var item in Player.IdxBunny)
            {
                var rowStart = item[0];
                var colStart = item[1];
                if (rowStart + 1 < matrix.GetLength(0))
                {
                  
                    if (matrix[rowStart+1, colStart] == 'P')
                    {
                        matrix[rowStart+1, colStart] = 'B';
                        Player.Dead = true;
                        

                        
                    }
                    else
                    {
                        matrix[rowStart+1, colStart] ='B';
                        
                    }
                }
                if (rowStart - 1 >= 0)
                {
                    
                    if (matrix[rowStart-1, colStart] == 'P')
                    {
                        matrix[rowStart-1, colStart] = 'B';
                        Player.Dead = true;
                       


                        
                    }
                    else
                    {
                        matrix[rowStart-1, colStart] = 'B';

                    }
                }

                if (colStart + 1 < matrix.GetLength(1))
                {
                   
                    if (matrix[rowStart, colStart+1] == 'P')
                    {
                        matrix[rowStart, colStart+1] = 'B';
                        Player.Dead = true;
                       

                        
                    }
                    else
                    {
                        matrix[rowStart, colStart+1] = 'B';

                    }
                }

                if (colStart - 1 >= 0)
                {
                    if (matrix[rowStart, colStart-1] == 'P')
                    {
                        matrix[rowStart, colStart-1] = 'B';
                        Player.Dead = true;
                       
                        
                    }
                    else
                    {
                        matrix[rowStart, colStart-1] = 'B';

                    }
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'B')
                    {
                        var idx = new int[] {i, j};
                        Player.IdxBunny.Add(idx);
                    }
                }

                
            }

        }

        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
        private static void Info(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                }

            }
        }
    }
}

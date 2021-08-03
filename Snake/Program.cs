using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
    struct Position
    {
        public int Row;
        public int Col;

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            var symbol = '>';
            Position[] positions = new Position[]
            {
                new Position(-1,0),
                new Position(1,0),
                new Position(0,-1),
                new Position(0,1)
            };
            
            var snake = InitialSnake();
            PrintSnake(snake, symbol);
            var direction = 3;
            var rng = new Random();
            var apple = new Position();
            int score = 0;
            var enemy = new Position[10];
            int speed = 100;
            do
            {
                apple = new Position(rng.Next(0, Console.WindowHeight), rng.Next(0, Console.WindowWidth));
            } while (snake.Contains(apple));

            Console.SetCursorPosition(apple.Col, apple.Row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('A');
            for (int i = 0; i < enemy.Length; i++)
            {
                var enemySpawn = new Position();
                do
                {
                    enemySpawn = new Position(rng.Next(0, Console.WindowHeight), rng.Next(0, Console.WindowWidth));

                } while (snake.Contains(enemySpawn) &&( apple.Row==enemySpawn.Row && apple.Col==enemySpawn.Col));

                enemy[i] = enemySpawn;

            }

            foreach (var item in enemy)
            {
                Console.SetCursorPosition(item.Col, item.Row);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write('X');
            }
            while (true)
            { 
                var last = snake.Dequeue();
                Console.SetCursorPosition(last.Col, last.Row);
                Console.Write(" ");
                
                Direction(ref direction, ref symbol);
                var snakeLast = snake.Last();
                var nextMove = positions[direction];
                var newHead = new Position(snakeLast.Row + nextMove.Row, snakeLast.Col + nextMove.Col);
                if (enemy.Contains(newHead))
                {
                    Console.SetCursorPosition(0,0);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Game over ! Your Score is {score}..");
                    break;
                }
                if (newHead.Row == apple.Row && newHead.Col == apple.Col)
                {
                    speed -= 10;
                    score += 100;
                    do
                    {
                        apple = new Position(rng.Next(0, Console.WindowHeight), rng.Next(0, Console.WindowWidth));
                    } while (snake.Contains(apple));
                    Console.SetCursorPosition(apple.Col, apple.Row);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('A');
                    snake.Enqueue(newHead);
                    

                }
                
                newHead = IfOutside(newHead);
                snake.Enqueue(newHead); 
                Thread.Sleep(speed);

                PrintSnake(snake,symbol);
              
            }
        }

        private static Position IfOutside(Position newHead)
        {
            if (newHead.Col < 0)
            {
                newHead.Col = Console.WindowWidth - 1;
            }
            else if (newHead.Row < 0)
            {
                newHead.Row = Console.BufferHeight - 1;
            }
            else if (newHead.Col >= Console.WindowWidth)
            {
                newHead.Col = 0;
            }
            else if (newHead.Row >= Console.BufferHeight)
            {
                newHead.Row = 0;
            }

            return newHead;
        }

        private static void Direction(ref int direction, ref char symbol)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 0;
                        symbol = '^';
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 1;
                        symbol = 'v';
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 2;
                        symbol = '<';
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 3;
                        symbol = '>';
                        break;
                }
            }
        }

        private static Queue<Position> InitialSnake()
        {
            Queue<Position> snake = new Queue<Position>();
            for (int i = 0; i < 10; i++)
            {
                snake.Enqueue(new Position(0, i));
            }

            return snake;
        }

        private static void PrintSnake(Queue<Position> snake,char symb)
        {
            char body = '~';
            var current = snake.ToArray();
           
            for (int i = 0; i < snake.Count; i++)
            {
               
                if (i == snake.Count - 1) body = symb;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(current[i].Col, current[i].Row);
                Console.Write(body);
               
            }

        }
    }
}

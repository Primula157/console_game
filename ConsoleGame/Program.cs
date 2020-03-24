using System;
using System.Text;

namespace code_cademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Console Game";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetWindowSize(50, 20);
            Console.BufferHeight = 20;
            Console.BufferWidth = 50;

            var rand = new Random();
            int rows = 20;
            int cols = 50;
            int characterRow = rows / 2;
            int characterCol = cols / 2;
            string cursor = "<:";
            char fruit = '@';
            int fruitRow = rand.Next(2, rows);
            int fruitCol = rand.Next(2, cols);
            int score = 0;
            int colChange;
            int rowChange;


            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Press Q to exit\nScore: {score}");
                Console.SetCursorPosition(fruitCol, fruitRow); // set coordinates to spawn @fruit
                Console.Write(fruit); 
                Console.SetCursorPosition(characterCol, characterRow); //set coordinates for cursor
                Console.Write(cursor);

                var cki = Console.ReadKey(false); //


                if (cki.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    break;
                }

                string key = cki.Key.ToString();

                Game.UpdatePosition(key, out colChange, out rowChange);
                characterCol += colChange;
                characterRow += rowChange;

                cursor = Game.UpdateCursor(key);

                characterCol = Game.KeepInBounds(characterCol, cols);
                characterRow = Game.KeepInBounds(characterRow, rows);

                if (Game.DidScore(characterCol, characterRow, fruitCol, fruitRow))
                {
                    fruitRow = rand.Next(2, rows);
                    fruitCol = rand.Next(2, cols);
                    score++;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;

/*
 * Вложенные циклы
 */
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("цикл 1 итерация № " + i);
            for (int h = 1; h <= 5; h++)
            {
                Console.WriteLine("\t цикл 2 итерация № " + h);
                for (int k = 1; k <= 2; k++)
                {
                    Console.WriteLine("\t\t цикл 3 итерация № " + k);
                }
            }
        }

        Console.ReadLine();
        Console.WriteLine("Высота");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Ширина");
        int width = int.Parse(Console.ReadLine());

        for (int cube = 0; cube < height; cube++)
        {
            for (int line = 0; line < width; line++)
            {
                Console.Write("#");

            }
            Console.WriteLine();
        }

        Console.ReadLine();

        // Example_1

        int rows = 5;
        int columns = 10;
        var myArray = GetRandomArray(rows, columns);

        for (int g = 0; g < rows; g++)
        {
            for (int l = 0; l < columns; l++)
            {
                Console.Write($"{myArray[g, l]}\t");
            }

            Console.WriteLine();
        }

        Console.ReadLine();

        /*
         * Example_2
         */
        var gamesInfo = GetGamesInfo();

        for (int u = 0; u < gamesInfo.Count; u++)
        {
            Console.WriteLine($"{gamesInfo[u].TypeOfGame}:");

            for (int p = 0; p < gamesInfo[u].Games.Count; p++)
            {
                Console.WriteLine($" {gamesInfo[u].Games[p].Name}");
            }

            Console.WriteLine();
        }

        Console.ReadLine();

        /*
         * HomeWork
         */
        for (int r = 0; r < 10; r++)
        {
            for (int rr = 0; rr <= r; rr++)
            {
                Console.Write("#");
            }

            Console.WriteLine();

        }

        Console.WriteLine();
        Console.WriteLine();

        for (int r = 10; r > 0; r--)
        {
            for (int rr = 0; rr < r; rr++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int r = 10; r > 0; r--)
        {
            for (int rr = 1; rr < r; rr++)
            {
                Console.Write(" ");
            }

            for (int rrr = 0; rrr < 11 - r; rrr++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int r = 0; r < 10; r++)
        {
            for (int rr = 0; rr < r; rr++)
            {
                Console.Write(" ");
            }

            for (int rrr = 0; rrr < 10 - r; rrr++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.ReadLine();
    }

    /*
    * Example_1
    */
    static int[,] GetRandomArray(int rows, int columns)
    {
        Random random = new Random();
        var result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                //Генерация случайного числа от 0 до 100
                result[i, j] = random.Next(100);
            }
        }

        return result;
    }

    /*
     * Example_2
     */
    static List<GameInfo> GetGamesInfo()
    {
        return new List<GameInfo>()
            {
                new GameInfo
                {
                    TypeOfGame = GameType.RPG,
                    Games = new List<Game>()
                    {
                        new Game() { Name = "Fallout 4"},
                        new Game() { Name = "Gothic 2"},
                        new Game() { Name = "The Elder Scrolls 3: Morrowind"}
                    }
                },
                new GameInfo
                {
                    TypeOfGame = GameType.Shooter,
                    Games = new List<Game>()
                    {
                        new Game() { Name = "Counter-Strike: Global Offensive"},
                        new Game() { Name = "Battlefield 4"},
                        new Game() { Name = "Doom"}
                    }
                },
                new GameInfo
                {
                    TypeOfGame = GameType.Strategy,
                    Games = new List<Game>()
                    {
                        new Game() { Name = "Civilization VI"},
                        new Game() { Name = "Rome: Total War"},
                        new Game() { Name = "Starcraft II"}
                    }
                }
        };
    }
}
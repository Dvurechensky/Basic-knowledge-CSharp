using System;

/*
 * Трехмерные и более массивы 
 */

namespace Lesson_34___Трехмерные_массивы__многомерные_массивы_любой_мерности
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,,] myArray = new int[3, 5, 4, 7];
            int[,,] myArray_1 = new int[3, 5, 7];
            Random rnd = new Random();
            myArray_1[0, 1, 1] = 60;

            Console.WriteLine(myArray_1[0, 1, 1]);

            int[,,] myArray_2 =
            {
                {
                    {1, 2 },
                    {2, 3 }
                },
                {
                    {1, 2 },
                    {2, 3 }
                },
                {
                    {1, 2 },
                    {2, 3 }
                }
            };


            Console.ReadLine();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int o = 0; o < myArray.GetLength(2); o++)
                    {
                        for (int k = 0; k < myArray.GetLength(3); k++)
                        {
                            myArray[i, j, o, k] = rnd.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine($"Book №{i + 1}\n");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"\t Page №{j + 1}\n");

                    for (int o = 0; o < myArray.GetLength(2); o++)
                    {
                        Console.WriteLine($"\t\t List №{o + 1}\n");

                        for (int k = 0; k < myArray.GetLength(3); k++)
                        {
                            Console.Write(myArray[i, j, o, k] + "\t");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("##################################");
            }


            Console.ReadLine();

            int[][][][] arrayZub = new int[rnd.Next(3, 6)][][][];

            for (int i = 0; i < arrayZub.Length; i++)
            {
                arrayZub[i] = new int[rnd.Next(4, 9)][][];
                for (int j = 0; j < arrayZub[i].Length; j++)
                {
                    arrayZub[i][j] = new int[rnd.Next(2, 5)][];

                    for (int o = 0; o < arrayZub[i][j].Length; o++)
                    {
                        arrayZub[i][j][o] = new int[rnd.Next(2, 5)];
                        for (int l = 0; l < arrayZub[i][j][o].Length; l++)
                        {
                            arrayZub[i][j][o][l] = rnd.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < arrayZub.Length; i++)
            {
                Console.WriteLine($"Book №{i + 1}\n");
                for (int j = 0; j < arrayZub[i].Length; j++)
                {
                    Console.WriteLine($"\t Page №{j + 1}\n");

                    for (int o = 0; o < arrayZub[i][j].Length; o++)
                    {
                        Console.WriteLine($"\t\t List №{o + 1}\n");

                        for (int k = 0; k < arrayZub[i][j][o].Length; k++)
                        {
                            Console.Write(arrayZub[i][j][o][k] + "\t");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("************************************");
            }
        }
    }
}

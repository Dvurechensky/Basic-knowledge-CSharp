using System;

/*
 * Заполнение двумерного массива случайными числами
 * 
 * Заполнение двумерного масива с клавиатуры
 */

namespace Lesson_32___Заполнение_двумерного_масива__случайными_числами
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 2];
            string[,] myArray1 = new string[2, 2];

            Random rnd = new Random();

            //Random
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = rnd.Next(0, 1000);
                }
            }

            //Int
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write($"Введите значение в элемент массива [myArray] под индексом [{0}][{1}]: ", y, x);
                    myArray[y, x] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }

            //String
            for (int y = 0; y < myArray1.GetLength(0); y++)
            {
                for (int x = 0; x < myArray1.GetLength(1); x++)
                {
                    Console.Write($"Введите значение в элемент массива [myArray1] под индексом [{0}][{1}]: ", y, x);
                    myArray1[y, x] = Console.ReadLine();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int y = 0; y < myArray1.GetLength(0); y++)
            {
                for (int x = 0; x < myArray1.GetLength(1); x++)
                {
                    Console.Write(myArray1[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

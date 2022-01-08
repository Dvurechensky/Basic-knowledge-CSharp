using System;

/*
 * двумерный массив
 * 
 * инициализация
 * 
 * обращение к элементам двумерного массива
 */

namespace Lesson_30___Двумерный_массив.Объявление.Инициализация.Индексы
{
    class Program
    {
        static void Main(string[] args)
        {
            //тип_данных [,] имя_массива;

            int[,] myArray = new int[3, 5];
            int[,] myArray_1 =
            {
                { 34, 44, 55, 22, 33 },
                { 34, 44, 55, 22, 33 },
                { 34, 44, 55, 22, 33 }
            };

            
            myArray[0, 2] = 90;

            Console.WriteLine(myArray[0,2]);
        }
    }
}

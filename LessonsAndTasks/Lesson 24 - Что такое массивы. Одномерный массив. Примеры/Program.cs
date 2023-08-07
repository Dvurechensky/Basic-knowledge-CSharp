using System;

/*
 * Массивы
 * 
 * Одномерные массивы
 * 
 * Тип_элементов_массива [] имя_массива;
 */

namespace Lesson_24___Что_такое_массивы.Одномерный_массив.Примеры
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[0] = 10;
            myArray[1] = 3;

            int a = myArray[0];

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}

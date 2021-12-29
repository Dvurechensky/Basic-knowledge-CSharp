using System;
using System.Linq;
/*
 * Массивы
 * 
 * Одномерные массивы
 * 
 * Способы инициализации массива
 */

namespace Lesson_25___Инициализация_массива.Способы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray_1 = new int[5] { 5, 6, 7, 8, 9 };
            int[] myArray_2 = new int[] { 5, 6, 7, 8 };
            int[] myArray_3 = new [] { 5, 6, 7, 8 };
            int[] myArray_4 = { 5, 6, 7, 8 };
            int[] myArray_5 = Enumerable.Repeat(5, 10).ToArray();
            int[] myArray_6 = Enumerable.Range(4, 5).ToArray();


            Console.ReadLine();
        }
    }
}

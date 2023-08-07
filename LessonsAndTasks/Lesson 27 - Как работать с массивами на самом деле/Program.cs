using System;
using System.Linq;

/*
 * как работать с массивами на самом деле
 */

namespace Lesson_27___Как_работать_с_массивами_на_самом_деле
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 64, 99, 4, 42, 5};

            int value_0 = myArray.Min();
            int[] value_1 = myArray.Where(i => i % 2 != 0).ToArray(); //Перебор по нужному условию
            Console.WriteLine(value_1);
            int[] result = myArray.Distinct().ToArray();//Только уникальные
            int[] result_1 = myArray.OrderBy(i => i).ToArray();//Сортировка
            Array.Sort(myArray);
            Array.Find(myArray, i => i < 70);
            Array.FindLast(myArray, i => i < 70);
            int[] result_2 = Array.FindAll(myArray, i => i < 70);
            int result_3 = Array.FindIndex(myArray, i => i == 70);
            Array.Reverse(myArray);
            int result_4 = myArray.Where(i => i < 70).FirstOrDefault(); //Первое число меньше 70

            Console.ReadLine();
        }
    }
}

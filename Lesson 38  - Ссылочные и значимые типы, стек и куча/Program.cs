using System;

/*
 * Ссылочные (reference type) и значимые (value types) типы
 * 
 * Стек (stack) и куча (heap)
 */

namespace Lesson_38____Ссылочные_и_значимые_типы__стек_и_куча
{
    class Program
    {
        //Данные удаляются из стека после выполненения
        static void Foo(int a)
        {
            a = 5;
        }

        static void Bar(int[] a)
        {
            a[0] = 3;
        }


        //Stack - Enum, Struct 
        //Heap - Class
        static void Main(string[] args)
        {
            {
                int y = 2;
            }

            //Stack
            int a = 4;
            System.Int32 g = 5;

            //Heap
            Random rnd = new Random();

            //Heap gg(data) - реальные данные теущего массива Stack gg(ref) - сыылка
            Array array;
            int[] gg;

            //Stack
            ConsoleKey consoleKey;

            Foo(a);

            int[] ba = new int[1];
            ba[1] = 2;
            Bar(ba);
        }
    }
}

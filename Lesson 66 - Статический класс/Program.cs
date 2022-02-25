using System;

/*
 * Ключевое слово static
 * 
 * Статический класс
 */

namespace Lesson_66___Статический_класс
{
    static class Herro
    {
        public static void Foo()
        {
            Console.WriteLine("Вызвал Foo()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Herro.Foo();
        }
    }
}

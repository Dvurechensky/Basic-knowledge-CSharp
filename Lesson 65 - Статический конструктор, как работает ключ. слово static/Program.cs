using System;

/*
 * Ключевое слово static
 * 
 * Статический конструктор
 */

namespace Lesson_65___Статический_конструктор__как_работает_ключ.слово_static
{
    class Terro
    {
        public Terro()
        {
            Console.WriteLine("Конструктор");
        }

        public Terro(int a)
        {
            Console.WriteLine("Конструктор new a");
        }

        //Модификаторы доступа вообще не используются
        //Может быть только один статический конструктор в классе
        //Нельзя использовать перегрузку
        //Не может принимать параметров
        //Выполняется только один раз
        static Terro()
        {
            Console.WriteLine("Статический конструктор");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Terro terro = new Terro();
            new Terro();
            new Terro();
            new Terro();
        }
    }
}

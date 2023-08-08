using System;

/*
 * Ключевое слово static
 * 
 * Статический конструктор
 */

namespace Lesson_65___Статический_конструктор__как_работает_ключ.слово_static
{
    class dbRepository
    {
        private static string connectString;

        static dbRepository() //один раз срабатывает после старта программы
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            connectString = configurationManager.GetConnectionString();
        }

        public void GetData()
        {
            Console.WriteLine($"Использую: {connectString}");
        }
    }

    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "localDB";
        }
    }

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

        public static int g;

        public static void Foo()
        {
            Console.WriteLine("Foo");
            g = 2;
        }
    }

    class Program
    {
        static void Main()
        {
            Terro.Foo();
            Terro terro = new Terro();
            new Terro();
            new Terro();
            new Terro();

            dbRepository dbRepository = new dbRepository();
            dbRepository.GetData();
        }
    }
}

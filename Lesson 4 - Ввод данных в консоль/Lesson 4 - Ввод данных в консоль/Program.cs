using System;


/*
 * Ввод данных в консоль
 */


namespace Lesson_4___Ввод_данных_в_консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;

            data = Console.ReadLine();

            Console.WriteLine("Привет " + data + "!!!");//Конкатенация
        }
    }
}

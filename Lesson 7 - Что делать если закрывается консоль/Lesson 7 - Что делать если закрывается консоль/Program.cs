using System;


/*
 * Что делать если закрывается консоль?
 */

namespace Lesson_7___Что_делать_если_закрывается_консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консоль закрывается! =)");
            Console.ReadLine();//Console.Read() || Console.ReadKey()
        }
    }
}

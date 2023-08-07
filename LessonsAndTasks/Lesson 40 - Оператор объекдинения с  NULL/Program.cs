using System;

/*
 * Оператора объединения с NULL ??
 */ 

namespace Lesson_40___Оператор_объекдинения_с__NULL
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            Console.WriteLine(str ?? "NULL");

            Console.WriteLine("Lenght" + str ?? "no");
        }
    }
}

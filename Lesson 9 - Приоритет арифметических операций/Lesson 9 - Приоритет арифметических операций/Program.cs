using System;


/*
 * Приоритет арифметических операций
 */

namespace Lesson_9___Приоритет_арифметических_операций
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 2 + 2 * 2;
            int result1 = (2 + 2) * 2;

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}

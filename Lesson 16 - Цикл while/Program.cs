using System;

/*
 * Цикл while
 */

namespace Lesson_16___Цикл_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int.TryParse(Console.ReadLine(), out int limit);
            while (count < limit)
            {
                count++;
                Console.WriteLine($"{count} Выполняем действия");
            }
        }
    }
}

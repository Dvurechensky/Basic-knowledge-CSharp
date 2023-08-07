using System;

/*
 * Цикл do while
 */

namespace Lesson_17___Цикл_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            //Всегда выполняется один раз даже если условие цикла не выполянется
            while (count < 5)
            {
                count++;
                Console.WriteLine($"{count} Действие");
            }

            do
            {
                count++;
                Console.WriteLine($"{count} Действие");
            } while (count < 5);
        }
    }
}

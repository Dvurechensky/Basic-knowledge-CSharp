using System;

/*
 * Цикл for
 */

namespace Lesson_18___Цикл_for
{
    class Program
    {
        private static int count;

        static void Main(string[] args)
        {
            //Переменная count в счетчике существует только внутри цикла
            for(byte count = 0; count < 10; count++)
            {
                Console.WriteLine(count);
            }

            //Переменная count объявляется вне цикла и существует вне зависимости от положения цикла в коде
            while (count < 10)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}

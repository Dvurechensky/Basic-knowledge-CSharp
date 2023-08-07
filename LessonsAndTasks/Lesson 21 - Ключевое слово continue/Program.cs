using System;

/*
 * ключевое слово continue
 */

namespace Lesson_21___Ключевое_слово_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 2)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}

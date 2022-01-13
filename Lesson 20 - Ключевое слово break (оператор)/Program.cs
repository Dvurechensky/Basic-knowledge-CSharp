using System;

/*
 *  ключевое слово break 
 */

namespace Lesson_20___Ключевое_слово_break__оператор_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                string msg = Console.ReadLine();

                if (msg == "exit")
                    break;
                else if (i == 10)
                    break;
            }

            Console.ReadLine();
        }
    }
}

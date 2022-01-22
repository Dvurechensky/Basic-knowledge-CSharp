using System;

/*
 * Область видимости, или контекст переменной
 * Конфликты областей видимости
 */

namespace Lesson_37____Область_видимости__контекст_переменной__конфликт_областей
{
    class Program
    {
        static int a = 3;
        static int aa = 3;

        static void Foo()
        {
            int b = 0;

            int aa = 2;
            Console.WriteLine(aa);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                ++i;
            }
            Foo();
            //Область видимости и конктекст переменной - это одно и то же
            a++;
        } 
    }
}

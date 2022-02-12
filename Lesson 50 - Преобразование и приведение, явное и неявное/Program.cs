using System;

/*
 * Преобразование и приведение примитивных типов в C#
 */

namespace Lesson_50___Преобразование_и_приведение__явное_и_неявное
{
    class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            int a = 5;
            double aa = 5.7;
            Foo(a); //Пример не явного преобразования implicit - (расширяющее преобразование)
            Foo((float)aa); //Пример явного преобразования explicit (сужающее преобразование) - больший обьект в меньшую упаковку положили
            int h = 500;
            byte k = (byte)h;
            int b = 800;
            bool k_r = Convert.ToBoolean(b);
            int u = 300;
            float uu = 400F;
            float res_f = u + uu;
            int uuu = 300;
            float uuuu = 400F;
            int res_ff = (int)(uuu + uuuu);
        }
    }
}

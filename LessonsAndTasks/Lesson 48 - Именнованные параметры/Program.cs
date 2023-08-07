using System;

/*
 * Именнованные параметры
 */

namespace Lesson_48___Именнованные_параметры
{
    class Program
    {
        //Параметры по умолчанию всегда должны быть в конце списка
        private static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine($"Значение переменной a = {a}");
                Console.WriteLine($"Значение переменной b = {b}");
                Console.WriteLine($"Значение переменной result = {result}");
            }

            return result;
        }

        static void Main(string[] args)
        {
            Sum(a: 1, b: 2);

            int firstValue = 2;
            int secondValue = 3;

            //Чтобы внести ясность тому что выполнит функция 
            Sum(a: firstValue, b: secondValue, enableLogging: true);
        }
    }
}

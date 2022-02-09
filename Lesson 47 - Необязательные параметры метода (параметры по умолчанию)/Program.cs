using System;

/*
 * Необязательные параметры методов
 */

namespace Lesson_47___Необязательные_параметры_метода__параметры_по_умолчанию_
{
    class Program
    {
        //Параметры по умолчанию всегда должны быть в конце списка
        private static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if(enableLogging)
            {
                Console.WriteLine($"Значение переменной a = {a}");
                Console.WriteLine($"Значение переменной b = {b}");
                Console.WriteLine($"Значение переменной result = {result}");
            }

            return result;
        }

        static void Main(string[] args)
        {
            Sum(2, 3);
        }
    }
}

using System;


/*
 * ОПЕРАТОРЫ
 * 
 * Арифметические операции с числами
 * 
 * 1. Напишите программу, вычисляющую среднее арифметическое двух чисел
 * 
 * 2. Введите три числа и выведите  на экран значение суммы и произведения этих чисел
 * 
 * 3. Напишите простой конвертер валют (без возможности динамического выбора валюты
 *    пользователем). Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста
 */

namespace Lesson_8___Арифметические_операции_с_числами
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, a = 2, b = 5;

            result = a + b;
            result = a - b;
            result = a * b;
            result = a / b;
            result = a % b;
            double result_d = (double) a / b;

            Console.WriteLine(result);
            Console.WriteLine(result_d);
        }
    }
}

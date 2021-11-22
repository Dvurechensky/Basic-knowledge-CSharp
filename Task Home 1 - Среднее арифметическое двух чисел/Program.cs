using System;


/*
 * 1. Напишите программу, вычисляющую среднее арифметическое двух чисел.
 */

namespace Task_Home_1___Среднее_арифметическое_двух_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 My
            double a1, b1, result_arifm; 
            // 1 ошибка! Вместо a1 b1  нужно написать firstValue secondValue - чтобы это было читаемо!

            Console.WriteLine("Введите число 1");

            bool num_1 = double.TryParse(Console.ReadLine(), out a1);

            Console.WriteLine("Введите число 2");

            bool num_2 = double.TryParse(Console.ReadLine(), out b1);

            result_arifm = (a1 + b1) / 2;

            Console.WriteLine((num_1 && num_2) ? "Среднее арифметическое двух чисел: " + result_arifm :
                                                "Строки содержат неверные символы!" +
                                                Environment.NewLine +
                                                "Среднее арифметическое двух чисел: " + result_arifm);
        }
    }
}

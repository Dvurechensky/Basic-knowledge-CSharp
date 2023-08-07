using System;

/*
 * 1. Напишите программу, вычисляющую среднее арифметическое двух чисел.
 */
class Program
{
    static void Main()
    {
        double firstValue, secondValue, result_arifm; 

        Console.WriteLine("Введите число 1");

        bool num_1 = double.TryParse(Console.ReadLine(), out firstValue);

        Console.WriteLine("Введите число 2");

        bool num_2 = double.TryParse(Console.ReadLine(), out secondValue);

        result_arifm = (firstValue + secondValue) / 2;

        Console.WriteLine((num_1 && num_2) ? "Среднее арифметическое двух чисел: " + result_arifm :
                                            "Строки содержат неверные символы!" +
                                            Environment.NewLine +
                                            "Среднее арифметическое двух чисел: " + result_arifm);
        Console.ReadKey();
    }
}
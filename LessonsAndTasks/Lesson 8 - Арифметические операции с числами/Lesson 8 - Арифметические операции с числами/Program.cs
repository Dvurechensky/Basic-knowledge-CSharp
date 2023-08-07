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
class Program
{
    static void Main()
    {
        int result, a = 4, b = 5;

        result = a + b;
        Console.WriteLine($"Сумма: {result}");
        result = a - b;
        Console.WriteLine($"Разность: {result}");
        result = a * b;
        Console.WriteLine($"Произведение: {result}");
        result = a / b;
        Console.WriteLine($"Деление: {result}");
        result = a % b;
        Console.WriteLine($"Деление с остатком: {result}");
        double result_d = (double) a / b;
        Console.WriteLine($"Деление с конвертацией с приведением к формату double: {result_d}");
        Console.ReadKey();
    }
}
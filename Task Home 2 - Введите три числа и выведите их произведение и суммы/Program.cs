using System;


/*
 * 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел.
 */

namespace Task_Home_2___Введите_три_числа_и_выведите_их_произведение_и_суммы
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2
            int g1, g2, g3, res_sum, res_multy;
            // 1 ошибка - названия переменных g1 g2 g3  на firstValue secondValue thirdValue

            Console.WriteLine("Введите число 1: ");

            int.TryParse(Console.ReadLine(), out g1);

            Console.WriteLine("Введите число 2: ");

            int.TryParse(Console.ReadLine(), out g2);

            Console.WriteLine("Введите число 3: ");

            int.TryParse(Console.ReadLine(), out g3);

            res_sum = g1 + g2 + g3;
            res_multy = g1 * g2 * g3;

            Console.WriteLine("Результат суммы чисел: " + res_sum);

            Console.WriteLine("Результат умножения чисел: " + res_multy);
        }
    }
}

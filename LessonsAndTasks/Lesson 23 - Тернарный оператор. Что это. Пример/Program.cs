using System;

/*
 * 
 * Тернарный оператор.
 * 
 * [первый операнд - условие]?[второй операнд if_true]:[третий операнд if_false]
 * 
 */

namespace Lesson_23___Тернарный_оператор.Что_это.Пример
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            //Унарная операция
            a++;

            int b = 0;
            //Бинарная операция
            int c = a + b;

            //Тернарная операция
            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == storedPassword)
                accessAllowed = true;
            else
                accessAllowed = false;

            Console.WriteLine(accessAllowed);

            Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword ? true : false;

            Console.WriteLine(accessAllowed ? "успешно" : "не успешно");

            Console.ReadLine();

            accessAllowed = Console.ReadLine() == "qwerty";
            Console.WriteLine(accessAllowed ? "успешно" : "не успешно");

            Console.ReadLine();

            int inputData = int.Parse(Console.ReadLine());
            int outputData = inputData < 0 ? 0 : inputData;
            Console.WriteLine(outputData);

            Console.ReadLine();
        }
    }
}

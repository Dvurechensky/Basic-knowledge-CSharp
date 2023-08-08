using System;

/*
 * Функции и методы, что это, примеры
 *
 *  модификаторы тип_возвращаемого значения название_метода (параметры)
 *  {
 *      тело метода
 *  }
 */
class Program
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Введите число №1: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите число №2: ");
        b = int.Parse(Console.ReadLine());

        c = a + b;

        Console.WriteLine(c);

        Console.WriteLine(Sum(a, b));

        Console.ReadLine();

        PrintLine(c);

        //Дз №1 (диапазон символов)
        // Написать метод который выводит на экран строку
        // Символы из которых состоит строка и их количество вводятся пользователем
        PrintStr(10, new char[2] { 'Q', 'Z' });
        //Дз №2 
        // Написать метод для поиска индекса элемента массива (тип элементов в массиве -int)
        // Метод должен вернуть индекс первого найденного элемента (если он будет найден)
        int[] test_Array = new int[10] { 2, 4, 5, 6, 45, 5, 6, 3, 4222, 6 };
        Console.WriteLine($"Индекс элемента {4222} массива test_Array: " + CheckIndexArray(4222, test_Array));
        Console.ReadKey();
    }

    public static int Sum(int value_1, int value_2)
    {
        return value_1 + value_2;
    }

    public static void PrintLine(int value)
    {
        Console.WriteLine("printLine: " + value);
    }

    public static void PrintStr(uint length, char[] symbol)
    {
        Random rnd = new Random();
        string result = "";

        int index = 0;
        while (index <= length)
        {
            index++;
            char symRes = (char)rnd.Next(symbol[0], symbol[1]);
            result += symRes;
        }

        Console.WriteLine("String: " + result);
    }

    public static int CheckIndexArray(int value, int[] array)
    {
        if (array.Length != 0)
        {
            int index_Array = 0;
            foreach (var el_array in array)
            {
                index_Array++;
                if (el_array == value)
                    return index_Array - 1;
            }
        }

        return -1;
    }
}
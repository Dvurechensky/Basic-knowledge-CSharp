using System;
using System.Linq;

/*
 * Массивы и циклы
 */
class Program
{
    static void Main()
    {
        int[] myArray = { 10, 3, 2, 55 };

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        Console.ReadLine();

        #region TASK №1 - заполнить массив с клавиатуры
        Console.Write("Введите числа массива через пробел: ");
        string str = Console.ReadLine();
        int lenght = str.Where(c => c == ' ').Count();
        int[] arrayTask_1 = new int[lenght + 1];

        int index = 0;
        string tmpStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            tmpStr += str[i];
            if (str[i].ToString().Contains(" ") || i == (str.Length - 1))
            {
                arrayTask_1[index] = int.Parse(tmpStr);
                index++;
                tmpStr = "";
            }
        }
        Console.ReadLine();
        #endregion
        #region TASK №2 - вывести массив в обратном порядке
        Console.WriteLine("вывести массив в обратном порядке");
        for (int i = arrayTask_1.Length - 1; i >= 0; i--)
        {
            Console.Write(arrayTask_1[i] + " ");
        }
        Console.ReadLine();
        #endregion
        #region TASK №3 - найти сумму четных элементов
        Console.WriteLine("найти сумму четных элементов");
        int even = 0;
        for (int i = 0; i < arrayTask_1.Length; i++)
        {
            if (arrayTask_1[i] % 2 == 0)
                even += arrayTask_1[i];
        }
        Console.WriteLine($"Сумма четных равна {even}");
        Console.ReadLine();
        #endregion
        #region TASK №4 - найти наименьшее число в массиве
        Console.WriteLine("найти наименьшее число в массиве:");
        Console.WriteLine(arrayTask_1.Min());
        #endregion

        Console.ReadKey();
    }
}
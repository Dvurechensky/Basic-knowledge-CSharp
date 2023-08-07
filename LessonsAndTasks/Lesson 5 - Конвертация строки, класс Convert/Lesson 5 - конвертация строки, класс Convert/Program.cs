using System;
using System.Globalization;

/* 
 * конвертация строки
 * класс Convert
 */
class Program
{
    static void Main()
    {
        string str = "5";
        string str2 = "2";
        string str3 = "1,3";
        string str4 = "1.5";

        var numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        double db = Convert.ToDouble(str3);
        double db1 = Convert.ToDouble(str4, numberFormatInfo);

        Console.WriteLine(db);
        Console.WriteLine(db1);

        Console.WriteLine(str + str2);

        int a = Convert.ToInt32(str);   // Демонстрация Convert

        Console.WriteLine(a);

        Console.WriteLine("\t");

        string str1;

        int a1 = 0, a2 = 0, result;

        Console.WriteLine("Введите первое число: ");

        str1 = Console.ReadLine();

        if(!string.IsNullOrWhiteSpace(str1))
            a1 = Convert.ToInt32(str1);

        Console.WriteLine("Введите второе число: ");

        str1 = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(str1))
            a2 = Convert.ToInt32(str1);

        result = a1 + a2;

        Console.WriteLine("Сумма чисел: " + result);
    }
}
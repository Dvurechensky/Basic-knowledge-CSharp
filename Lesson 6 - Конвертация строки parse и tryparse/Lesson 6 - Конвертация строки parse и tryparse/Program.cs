using System;
using System.Globalization;


/*
 * конвертация строки
 * parse и tryparse
 */

namespace Lesson_6___Конвертация_строки_parse_и_tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5";
            string str1 = "5.2";
            int a = int.Parse(str);
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
            };
            double a1 = double.Parse(str1, numberFormatInfo);


            string teststr = "34.3oeskfso";
            try
            {
                int f = Convert.ToInt32(teststr);
                int f1 = int.Parse(teststr);
                Console.WriteLine("Успешная конвертация");
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }

            string k = "2 авуыаыу ауыа";

            int l;

            //TryParse - Возвращает булевый результат о том - распарсил он строку или нет
            bool result = int.TryParse(k, out l);//Out - данная переменная будет модифицирована внутри метода,
                                                 //инициализирована и возвращена наружу
            Console.WriteLine(result ? "Операция успешна, значение: " + l : "Не удалось конвертировать!");
        }
    }
}

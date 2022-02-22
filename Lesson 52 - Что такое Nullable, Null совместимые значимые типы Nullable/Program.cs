using System;

/*
 * Null - совместимые значимые типы (Nullable)
 */

namespace Lesson_52___Что_такое_Nullable__Null_совместимые_значимые_типы_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            int? a = null;
            //Проверить есть ли в Nullable переменной значение
            Console.WriteLine(a == null); //True
            Console.WriteLine(a.HasValue); //False
            Console.WriteLine(a.GetValueOrDefault()); //0
            Console.WriteLine(a.GetValueOrDefault(3)); //3
            Console.WriteLine(a ?? 55); //55
            try
            {
                Console.WriteLine(a.Value); //InvalidOperationException
            }
            catch (Exception)
            {
                Console.WriteLine("InvalidOperationException");
            }
            DateTime? dateTime = null;
            Nullable<DateTime> dateTime1 = null;
            Console.WriteLine(dateTime1);

            int? aa = 5;
            int? b = 22;
            int? result = a + b;
            Console.WriteLine(result);
            Console.WriteLine(aa == b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
        }
    }
}

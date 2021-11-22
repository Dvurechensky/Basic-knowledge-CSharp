using System;


/*
 * Операторы отношений.
 * Операции сравнения.
 */

/*
    == Равно
    != Не равно
    >  Больше
    <  Меньше
    >= Больше или равно
    <= Меньше или равно
*/

namespace Lesson_12___Операторы_сравнения.Операции_сравнения
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4;
            bool result0 = a == b;
            bool result1 = a != b;
            bool result2 = a > b;
            bool result3 = a < b;
            bool result4 = a <= b;
            bool result5 = a >= b;
            Console.WriteLine(result0 + Environment.NewLine +
                              result1 + Environment.NewLine +
                              result2 + Environment.NewLine +
                              result3 + Environment.NewLine +
                              result4 + Environment.NewLine +
                              result5 + Environment.NewLine);
        }
    }
}

using System;
using System.Text;

/*
 * "Ядерный Ганди" и аримфметическое переполнение
 */

namespace Lesson_51___Арифметическое_переполнение__checked_unchecked
{
    class Program
    {
        static void Main()
        {
            #region Для целочисленных типов данных
            byte agression = 1;

            byte democracyModifier = 2;

            try
            {
                //Если вычесть из 1 2, то будет 255 а не 0, это арифметическое переполнение и слово checked это проверяет - uncehcked {} выключает проверку переполнения
                agression = checked((byte)(agression - democracyModifier)); //Служащее преобразование данных
                Console.WriteLine(agression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error");
            }
            #endregion

            #region Для дробных типов данных
            double a = 1.0 / 0.0;

            Console.WriteLine(double.IsInfinity(a)); //output: True

            double b = 0.0 / 0.0;

            Console.WriteLine(double.IsNaN(b)); //output: True

            double c = double.MaxValue + double.MinValue;

            Console.WriteLine(double.IsInfinity(c)); //output: True

            decimal aa = decimal.MaxValue;
            decimal bb = decimal.MaxValue;
            //*Для арифметических операндов типа decimal переполнение всегда показывает исключение
            //decimal cc = unchecked(a + b); 
            #endregion
        }
    }
}

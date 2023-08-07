using System;
using System.Collections.Generic;

/*
 * enum (перечисления)
 */

namespace Lesson_54___enum__что_это__и_для_чего_нужно___перечисления
{
    class Program
    {
        public enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key} \tKey Code {keyCode}");

                if (key == ConsoleKey.Enter)
                    Console.WriteLine("Enter");

                DayOfWeek dayOfWeek = DayOfWeek.Monday;

                //получаем тип данных
                Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

                Console.WriteLine(dayOfWeek);

                //приводим dayofweek к int
                Console.WriteLine((int)dayOfWeek);
                //приводим dayofweek к Dayofweek к int
                int value = 3;
                //Проверяем существования дня под таким номером в перечислении
                if(Enum.IsDefined(typeof(DayOfWeek), value))
                    Console.WriteLine((DayOfWeek)value);
                //получаем следующий день
                DayOfWeek nextday = GetNextDay(dayOfWeek);
                Console.WriteLine(nextday);

                //получить и вывести сразу все значения перечисления
                var values = Enum.GetValues(typeof(Color));

                foreach (var item in values)
                {
                    Console.WriteLine(item);
                }

                //перечисления можно парсить
                string str = Console.ReadLine();
                //ignoreCase - игнорировать большие и маленькие буквы
                Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
                Console.WriteLine(color);

                //ну и фишка которая известна из начальных уроков

                switch (color)
                {
                    case Color.White:
                        break;
                    case Color.Red:
                        break;
                    case Color.Green:
                        break;
                    case Color.Blue:
                        break;
                    case Color.Orange:
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// получаем следующий день
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

            return DayOfWeek.Monday;
        }
    }
}

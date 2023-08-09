using System;

/*
 * enum (перечисления)
 */
class Program
{
    public enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Orange
    }

    public static void Main()
    {
        while (true)
        {
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int)key;

            Console.WriteLine($"\tEnum {key} \tKey Code {keyCode}");

            if (key == ConsoleKey.Enter)
                Console.WriteLine("Enter");

            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            // получаем тип данных
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)).Name);

            Console.WriteLine(dayOfWeek);

            // приводим dayofweek к int
            Console.WriteLine((int)dayOfWeek);
            // приводим dayofweek к Dayofweek к int
            int value = 3;
            // Проверяем существования дня под таким номером в перечислении
            if (Enum.IsDefined(typeof(DayOfWeek), (DayOfWeek)value))
                Console.WriteLine((DayOfWeek)value);
            // получаем следующий день
            DayOfWeek nextday = GetNextDay(dayOfWeek);
            Console.WriteLine(nextday);

            // получить и вывести сразу все значения перечисления
            var values = Enum.GetValues(typeof(Color));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Write to name Color [White][Red][Green][Blue][Orange]");
            // перечисления можно парсить
            string str = Console.ReadLine();
            // ignoreCase - игнорировать большие и маленькие буквы
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);

            // ну и фишка которая известна из начальных уроков
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
    /// <param name="day">day/param>
    /// <returns>DayOfWeek</returns>
    public static DayOfWeek GetNextDay(DayOfWeek day)
    {
        if (day < DayOfWeek.Sunday)
            return day + 1;

        return DayOfWeek.Monday;
    }
}
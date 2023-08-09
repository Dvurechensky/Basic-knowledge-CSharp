using System;

/*
 * Ключевое слово params
 */
class Program
{
    private static int Sum(int a, int b)
    {
        return a + b;
    }

    private static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    /// <summary>
    /// Бонус
    /// </summary>
    /// <param name="parameters">список параметров</param>
    private static void ParObj(params object[] parameters)
    {
        string message = "Тип данных {0}, значение {1}";
        foreach (var item in parameters)
        {
            System.Console.WriteLine(message, item.GetType(), item);
        }
    }

    /// <summary>
    /// params - для того чтобы передавать параметры отдельно через запятую
    /// * не может быть двух params в методе
    /// * другой обычный параметр должен быть перед params
    /// </summary>
    /// <param name="message">сообщение</param>
    /// <param name="parameters">список параметров</param>
    /// <returns></returns>
    private static int SumParams(string message, params int[] parameters)
    {
        int result = 0;

        for (int i = 0; i < parameters.Length; i++)
        {
            result += parameters[i];
        }

        //or
        //parameters.Sum();

        return result;
    }

    static void Main()
    {
        int result = Sum(5, 10);

        Console.WriteLine(result);

        Console.WriteLine(SumParams("message", 1, 2, 3, 4));

        // *Бонус
        ParObj(1, 1.0, 1f, "dd", 'a', true);
        Console.ReadKey();
    }
}
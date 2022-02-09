using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

/*
 * Ключевое слово params
 */

namespace Lesson_46___Ключевое_слово_params
{
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

        //Бонус
        private static void ParObj(params object[] parameters)
        {
            string message = "Тип данных {0}, значение {1}";
            foreach (var item in parameters)
            {
                System.Console.WriteLine(message, item.GetType(), item);
            }
        }

        //params - для того чтобы передавать параметры отдельно через запятую
        // * не может быть двух params в методе
        // * другой обычный параметр должен быть перед params
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

        static void Main(string[] args)
        {
            int result = Sum(5, 10);

            System.Console.WriteLine(result);

            System.Console.WriteLine(SumParams("message", 1, 2, 3, 4));

            //Бонус
            ParObj(1, 1.0, 1f, "dd", 'a', true);
        }
    }
}

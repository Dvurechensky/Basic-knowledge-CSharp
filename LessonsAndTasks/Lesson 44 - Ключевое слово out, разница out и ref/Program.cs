using System.Text;

/*
 * Ключевое слово out
 * Разница между ref и out
 */

namespace Lesson_44___Ключевое_слово_out__разница_out_и_ref
{
    class Program
    {
        public static void Foo(ref int value)
        {
            value++;
            System.Console.WriteLine(value);
        }

        //out - обязывает нас присваивать значение переменной внутри метода
        public static void Bar(out int value)
        {
            value = 0;
            System.Console.WriteLine(value);
        }

        static void Main()
        {
            int a = 10;
            int aa;
            Foo(ref a);
            Bar(out aa);
            string str = "3";
            int.TryParse(str, out int result);
            Bar(out int aaa);//сразу можем объявить внутри метода с out
        }
    }
}

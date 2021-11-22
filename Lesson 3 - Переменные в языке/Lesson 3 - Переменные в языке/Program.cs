using System;


/*
 * Переменные в C#
 * 
 * Объявление (создание) переменных
 * 
 * Инициализация переменных
 * 
 * Присвоение значения переменной (помещение данных)
 */


namespace Lesson_3___Переменные_в_языке
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тип_данных имя_переменной;
            int a = 5, b = 9;

            //int b;
            //a = 5;
            //b = 6;
            Console.WriteLine(a);
   
            a = 747;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("\t");

            bool variable1 = false;
            bool Variable1 = false;
            bool variable2 = true;

            Console.WriteLine(variable1);
            Console.WriteLine(variable2);
            Console.WriteLine(Variable1);

            Console.WriteLine("\t");

            double t = 1.33;

            Console.WriteLine(t);

            char c = '#';
            string cc = "dfdfdsf";

            Console.WriteLine(c);
            Console.WriteLine(cc);

            Console.WriteLine("\t");
        }
    }
}

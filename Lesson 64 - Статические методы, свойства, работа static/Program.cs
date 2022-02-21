using System;

/*
 * Ключесвое слово static
 * 
 * Статические методы класса
 * 
 * Статические свойства класса
 */

namespace Lesson_64___Статические_методы__свойства__работа_static
{
    class MyClass
    {
        private static int a;

        private int b;

        public static Foo()
        {

        }

        public void Bar()
        {

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Bar();
        } 
    }
}

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
    class MyClass_1
    {
        private static int a;

        private int b;

        //public static Foo()
        //{

        //}

        public void Bar()
        {

        }


    }

    class Program_1
    {
        static void Main(string[] args)
        {
            MyClass_1 myClass = new MyClass_1();
            myClass.Bar();
        } 
    }
}

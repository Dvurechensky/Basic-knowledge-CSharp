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
    class Numb
    {
        public Numb()
        {
            Counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public int ObjectsCount
        {
            get { return counter; }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }
    }

    class MyClass_1
    {
        private static int a;

        private int b;

        public static void Foo()
        {
            Console.WriteLine("Вызван метод Foo()");
            a = 5;
            Console.WriteLine(a);
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar()");
            Console.WriteLine(a);
            Foo();
        }

        private static int c;

        public static int C
        {
            get { return c; }
            set { c = value; }
        }

        public static int D { get; set; }

    }

    class Program_1
    {
        static void Main(string[] args)
        {
            //Полиморфизм требует создание объекта класса и вызова метода на уровне экземпляра 
            MyClass_1 myClass = new MyClass_1();
            myClass.Bar();
            MyClass_1.Foo();// - статические методы недоступны на уровне экземпляра класса
            MyClass_1.C = 3;
            MyClass_1.D = 2;

            Numb numb = new Numb();
            Numb numb1 = new Numb();
            Numb numb2 = new Numb();
            Console.WriteLine(numb2.GetObjectsCount());
            Console.WriteLine(numb2.ObjectsCount);
            Console.WriteLine(Numb.Counter);
            Console.WriteLine(Numb.GetCounter());
        } 
    }
}

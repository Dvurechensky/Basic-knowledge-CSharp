using System;

/*
 * Что такое NULL
 */

namespace Lesson_39___Что_такое_NULL
{
    class MyClass
    {

    }

    struct MyStruct
    {

    }

    class Program
    {
        static void Heap()
        {
            int[] a = new int[10];
        }


        static void Main(string[] args)
        {
            bool b;
            int a;
            double d;

            //У классов - NULL
            Random random;
            int[] arr;
            MyClass myClass;

            MyStruct myStruct;

            Heap();
        }
    }
}

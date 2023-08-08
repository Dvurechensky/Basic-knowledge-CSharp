using System;

/*
 * Ссылочные (reference type) и значимые (value types) типы
 * 
 * Стек (stack) и куча (heap)
 */
class Program
{
    /// <summary>
    /// Данные удаляются из стека после выполненения
    /// </summary>
    /// <param name="a">val</param>
    static void Foo(int a)
    {
        a = 5;
    }

    static void Bar(int[] a)
    {
        a[0] = 3;
    }


    /// <summary>
    /// Stack - Enum, Struct 
    /// Heap - Class
    /// </summary>
    static void Main()
    {
        {
            int y = 2;
        }

        //Stack
        int a = 4;
        System.Int32 g = 5;

        //Heap
        Random rnd = new Random();

        //Heap gg(data) - реальные данные теущего массива Stack gg(ref) - ссылка
        Array array;
        int[] gg;

        //Stack
        ConsoleKey consoleKey;

        Foo(a);

        int[] ba = new int[1];
        ba[1] = 2;
        Bar(ba);
        Console.ReadKey();  
    }
}
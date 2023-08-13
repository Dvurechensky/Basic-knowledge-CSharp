using System;

/*
 * приведение типов и наследование
 * 
 * использование операторов as и is
 */
class BasePoint
{
    //
}

/// <summary>
/// *Все типы данных неявно унаследованы от типа Object
/// </summary>
class Point : BasePoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:\t{X}");
        Console.WriteLine($"Y:\t{Y}");
    }
}

class Program
{
    static void Main()
    {
        // ссылка базового класса может хранить любой тип наследников
        object obj = new Point { X = 5, Y = 2 };
        
        var point = (Point)obj;     // приведение object к Point
        point.Print();

        Foo(obj);
        Bar(obj);
        Console.ReadKey();
    }

    static void Foo(object obj)
    {
        var point = obj as Point;   // as - проверяет исключение при приведении типов
        point?.Print();
    }

    static void Bar(object obj)
    {
        // is - позволяет сразу поместить данные в объект если прошел проверку
        if (obj is Point point)
            point.Print();
    }
}
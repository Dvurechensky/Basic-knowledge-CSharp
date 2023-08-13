using System;

/*
 * наследование, конструкторы класса и ключевое слово base
 */
class Point2D
{
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
        Console.WriteLine("Point2D");
    }

    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:\t{X}");
        Console.WriteLine($"Y:\t{Y}");
    }
}

class Point3D : Point2D
{
    /// <summary>
    /// base - позволяет нам явно указать что мы хотим использовать (нечто) из базового класса
    /// при использовании ключевого слова base мы можем явно указать какой конструктор у базоваого класса используем
    /// </summary>
    /// <param name="x">#</param>
    /// <param name="y">#</param>
    /// <param name="z">#</param>
    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
        Console.WriteLine("Point3D");
    }
    public int Z { get; set; }

    public new void Print()
    {
        base.Print();   // аналог слова this (решающее неоднозначность)
        Console.WriteLine($"Z:\t{Z}");
    }
}

class Program
{
    static void Main()
    {
        //прежде чем создается класс конструктором - создаются все его предки
        var point3D = new Point3D(1, 2, 3);
        point3D.Print();
        var point2D = new Point2D(1, 2);
        point2D.Print();
        Console.ReadKey();
    }
}
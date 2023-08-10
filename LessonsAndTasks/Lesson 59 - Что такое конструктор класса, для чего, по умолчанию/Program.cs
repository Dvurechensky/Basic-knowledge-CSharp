using System;

/*
 * конструктор класса - это специальный метод класса, который вызывается при создании объекта такого класса (new)
 * 
 * конструктор по умолчанию
 */
class Point
{
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    private int _x;
    private int _y;

    public void Print()
    {
        Console.WriteLine($"X: {_x} \t Y: {_y}");
    }
}

class Gun
{
    /// <summary>
    /// конструктор без параметров
    /// 
    /// ctor - конструктор по умолчанию
    /// конструктор - тоже метод класса но только специальный, всегда public
    /// можно выставить что сделать по умолчанию 
    /// </summary>
    public Gun()
    {
        _isLoaded = true;
    }

    /// <summary>
    /// конструктор с параметрами
    /// </summary>
    /// <param name="isLoaded">#</param>
    public Gun(bool isLoaded)
    {
        this._isLoaded = isLoaded;
    }

    private bool _isLoaded;

    /// <summary>
    /// Поведение
    /// </summary>
    private void Reload()
    {
        Console.WriteLine("Заряжаю...");

        _isLoaded = true;

        Console.WriteLine("Заряжено!");
    }

    public void Shot()
    {
        if (!_isLoaded)
        {
            Console.WriteLine("Орудие не заряжено!");
            Reload();
        }

        Console.WriteLine("Пыщ - Пыщ!\n");
        _isLoaded = false;
    }
}

class Program
{
    static void Main()
    {
        //new - конструктор по умолчанию (спец метод для создания объекта класса)
        var gun = new Gun(isLoaded: true); 
        gun.Shot();
        Point point = new Point(1, 3);
        point.Print();
        Console.ReadKey();
    }
}
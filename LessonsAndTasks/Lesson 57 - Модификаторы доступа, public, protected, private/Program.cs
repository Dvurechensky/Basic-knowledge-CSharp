﻿using System;
using System.Reflection;

/*
 * модификаторы доступа public и private(используются для реализации инкапсуляции), для членов класса
 */
class Point
{
    /// <summary>
    /// *по умолчанию private
    /// </summary>
    int z = 3;

    public int x = 1;

    private int y = 5;

    private void PrintX()
    {
        Console.WriteLine($"X: {x}");
    }

    public void PrintY()
    {
        Console.WriteLine($"Y: {y}");
    }

    public void PrintPoint()
    {
        PrintX();
        PrintY();
    }
}

class Program
{
    static void Main()
    {
        Point point = new Point();

        point.PrintY();
        point.x = 2;
        point.PrintPoint();

        // проверим то, что по умолчанию стоит private у поля используя рефлексию
        var typeInfo = typeof(Point).
            GetFields(BindingFlags.Instance
                    | BindingFlags.NonPublic
                    | BindingFlags.Public);

        foreach (var item in typeInfo)
        {
            Console.WriteLine($"{item.Name}\t isPrivate: {item.IsPrivate}\t isPublic: {item.IsPublic}");
        }
        Console.ReadKey();
    }
}
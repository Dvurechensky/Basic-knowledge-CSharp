﻿using System;

/*
 * Cлючевое слово static
 * 
 * Статические поля класса (к полям, методам, свойствам, классам, конструкторам класса)
 */
class MyClass
{
    public int a;

    /// <summary>
    /// static - память которая выделяется доступна для всех объектов myclass
    /// общая для всех экземпляров класса
    /// </summary>
    public static int b;

    private static int g;

    public void SetG(int g) => MyClass.g = g;

    public void PrintG() => Console.WriteLine(g);
}

class Program
{
    static void Main()
    {
        MyClass.b = 4;

        MyClass myClass1 = new MyClass();
        myClass1.a = 22;

        MyClass myClass2 = new MyClass();
        myClass2.a = 44;

        myClass1.SetG(1);
        myClass2.PrintG();
        Console.ReadKey();
    }
}
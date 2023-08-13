using System;
using System.Collections;
using System.Collections.Generic; // обобщенные коллекции

/*
 * Обобщения(Generics)
 */
/// <summary>
/// Обобщения(Generics) - это такие конструкции языка которые позволяют 
/// писать код который будет одинаково работать с различными типами данных
/// общий код для разных типов данных, при этом мы сохраняем строгую типизацию языка
/// получаем несколько еще очень полезных и нужных бонусов
/// 
/// Например:
/// позволяет избежать процесса упаковки и распаковки значимых типов, что увеличивает производительность кода
/// </summary>
class Program
{
    static void Main()
    {
        int a = 1, b = 5;
        string c = "aa", d = "bb";
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"str_d = {d}, str_c = {c}");

        Swap(ref a, ref b);
        SwapType(ref c, ref d);

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"str_d = {d}, str_c = {c}");

        // List также использует обобщения
        var list = new List<int>();
        list.Add(2);
        list.Add(5);
        Console.WriteLine($"el[1] list: {list[0]}");
        list[0] = 1;
        Console.WriteLine($"Change el[1] list: {list[0]}");

        // ArrayList - аналог
        // но проблемы с упаковкой распаковкой так как это тип данных object
        // *почти не используется
        ArrayList arrayList = new ArrayList();
        arrayList.Add(2);
        arrayList.Add("33");
        Console.WriteLine($"el[1] arrayList: {arrayList[0]}");
        arrayList[0] = 1;
        Console.WriteLine($"Change el[1] arrayList: {arrayList[0]}");

        // Свой List
        var listString = new MyList<string>();
        listString.Add("aaa");
        listString.Add("bbb");
        Console.WriteLine($"1: {listString[0]} 2: {listString[1]}");
        Console.ReadKey();
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SwapType<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static T Foo<T>()
    {
        return default(T);
    }
}
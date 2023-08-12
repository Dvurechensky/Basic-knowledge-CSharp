using System;

class Kraft
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName() => Console.WriteLine($"Name: {FirstName}");
}

/// <summary>
/// Выполнено наследование 
/// все свойства, методы и поля унаследованы
/// </summary>
class Ivuc : Kraft
{
    public void PrintLastName() => Console.WriteLine($"LastName: {LastName}");
}

/// <summary>
/// наследование в Объектно-ориентированном программировании (ООП) 
/// позволяет избежать ненужного дублирования кода
/// позволяет реализовать полиморфизм
/// множественного наследования в C# нет (для классов)
/// </summary>
class Program
{
    static void Main()
    {
        var kraft = new Kraft
        {
            FirstName = "terry",
            LastName = "lamos"
        };
        kraft.PrintName();

        var ivuc = new Ivuc
        {
            FirstName = "terry",
            LastName = "lamos"
        };

        ivuc.PrintName();
        ivuc.PrintLastName();

        // Можно при инициализацими экземпляра класса, инициализировать его наследника
        // Тем самым, это помогает в работе старого функционала - он может работать и с наследниками 
        var kraft_ivuc = new Ivuc
        {
            FirstName = "terry",
            LastName = "lamos"
        };
        PrintFullName(kraft_ivuc);

        var teacher = new Teacher
        {
            FirstName = "John",
            LastName = "Karter"
        };

        var student = new Student
        {
            FirstName = "Garry",
            LastName = "Astos"
        };

        LP[] people = { teacher, student };
        PrintLP(people);
        Console.ReadKey();
    }

    static void PrintFullName(Kraft kraft)
    {
        Console.WriteLine($"Name: {kraft.FirstName} LastName: {kraft.LastName}");
    }

    static void PrintLP(LP[] persons)
    {
        foreach (var person in persons)
            person.PrintFullName();
    }
}
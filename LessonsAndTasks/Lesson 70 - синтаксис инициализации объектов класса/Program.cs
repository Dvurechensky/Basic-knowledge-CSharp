using System;

/*
 * синтаксиси инициализации объектов - процесс создания экземпляра объекта класса
 */
class Cat
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Cat() { }

    public Cat(string name) => Name = name;
}

class Program
{
    static void Main()
    {
        Cat cat_1 = new Cat("Барсик");
        Console.WriteLine(cat_1.Name);
        Cat cat_2 = new Cat();
        cat_2.Name = "Барс";
        cat_2.Age = 3;
        var cat_3 = new Cat     // альтернативная инициализация объекта
        {
            Name = "Жмур",
            Age = 4
        };
        // Для понимания зачем использовать альтернативную инициализацию
        var person1 = new Person();
        person1.FirstName = "Ранд";
        person1.LastName = "ал'Тор";

        var address = new Address();
        address.Country = "Andor";
        address.Region = "Dvurech";
        address.City = "Lug";

        person1.Address = address;

        // Выше читаемость кода
        var person2 = new Person
        {
            FirstName = "Ранд",
            LastName = "ал'Тор",
            Address = new Address
            {
                City = "Lug",
                Region = "Dvurech",
                Country = "Andor"
            }
        };

        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());
        Console.ReadKey();
    }
}
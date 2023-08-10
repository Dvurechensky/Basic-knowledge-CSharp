using System;

/*
 * ООП
 * методы объекта класса
 */

class Program
{
    static Student GetStudent()
    {
        return new Student
        {
            id = Guid.NewGuid(),
            firstName = "first",
            lastName = "last",
            middleName = "middle",
            age = 24,
            group = "professional"
        };
    }

    /// <summary>
    /// Функции и методы это одно и то же разница
    /// Функция которая является членом класса это метод (функций без классов не может быть) 
    /// </summary>
    static void Main()
    {
        var firstStudent = GetStudent();
        firstStudent.Print();
        string fullname = firstStudent.GetFullName();

        Console.WriteLine("\t== Car 1 ==");
        var car_1 = new Car();
        car_1.PrintSpeed();
        car_1.DriveForward();
        car_1.PrintSpeed();
        car_1.Stop();
        car_1.PrintSpeed();

        Console.WriteLine("\t== Car 2 ==");
        var car_2 = new Car();
        car_2.PrintSpeed();
        car_2.DriveBackward();
        car_2.PrintSpeed();
        Console.ReadKey();
    }
}
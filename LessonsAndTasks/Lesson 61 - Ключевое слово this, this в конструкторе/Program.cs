using System;

/// <summary>
/// -  this - можно получить доступ к текущему экземпляру класса
/// - применяет когда есть не однозначность в именах переменных конструктора и полей класса
/// </summary>
class Student
{
    public Student(string lastName, DateTime birthday)
    {
        this.lastName = lastName;
        this.birthday = birthday;
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
    {
        this.firstName = firstName;
        this.middleName = middleName;
    }

    public Student(Student student)
    {
        firstName = student.firstName;
        lastName = student.lastName;
        middleName = student.middleName;
        birthday = student.birthday;
    }

    private string firstName;
    private string middleName;
    private string lastName;
    private DateTime birthday;

    public void SetLastName(string lastName) => this.lastName = lastName;

    public void Print()
    {
        Console.WriteLine($"Имя: " + firstName +
            $"\nФамилия: " + lastName +
            $"\nОтчество: " + middleName +
            $"\nДата рождения: " + birthday);
    }
}

class Program
{
    static void Main()
    {
        Student student_1 = new Student("Qumo", new DateTime(2000, 10, 5));
        student_1.Print();
        Console.ReadKey();
    }
}
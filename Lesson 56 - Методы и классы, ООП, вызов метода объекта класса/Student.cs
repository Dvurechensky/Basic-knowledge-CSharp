using System;

namespace Lesson_56___Методы_и_классы__ООП__вызов_метода_объекта_класса
{
    class Student
    {
        public Guid id; // - специальная структура для описания объекта, создания уникальных id
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine($"id: {id}, \nfirstName: {firstName},\n" +
                              $"lastName: {lastName}, \nmiddleName: {middleName},\n" +
                              $"age: {age}, \ngroup: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}

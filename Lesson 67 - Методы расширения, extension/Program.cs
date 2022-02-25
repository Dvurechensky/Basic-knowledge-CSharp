using System;
using Extension;
using Students;
/*
 * Extension методы (метод расширения) (расширяющие методы)
 */

namespace Lesson_67___Методы_расширения__extension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Monday));
            Student student = new Student() { FirstName = "Джим", LastName = "Керри" };
            Console.WriteLine(student.GetFullName());
        }
    }
}

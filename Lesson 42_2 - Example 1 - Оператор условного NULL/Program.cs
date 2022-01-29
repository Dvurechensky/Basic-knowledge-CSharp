using Lesson_40_wf___Оператор_объекдинения_с__NULL;
using System;

/*
 * Оператор условного null
 */

namespace Lesson_42_2___Example_1___Оператор_условного_NULL
{
    class Program
    {
        static Person GetPerson()
        {
            Person person = null;
            return person;
        }

        static void Main(string[] args)
        {
            Person person = GetPerson();

            //person, Contacts и PhoneNumber - ссылочные типы
            Console.WriteLine(person?.Contacts?.PhoneNumber ?? "no data");
        }
    }
}

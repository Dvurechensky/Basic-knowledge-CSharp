using System;

/*
 * Частичные типы
 * 
 * partial классы (паршиал)
 * 
 * partial методы
 */

namespace Lesson_68___partial_класс__частичные_типы__partial_методы
{
    //позволяет код класса произнести в разных файлах (класс превращается в частичный)
    class Program
    {
        static void Main()
        {
            Person person = new Person("Джим", "Керри");
            person.PrintFullName();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_40_wf___Оператор_объекдинения_с__NULL
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {FirstName ?? "нет данных"} | Имя: {MiddleName ?? "нет данных"} | Отчество: {SecondName ?? "нет данных"}";
        }
    }
}

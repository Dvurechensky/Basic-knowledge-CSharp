namespace Lesson_40_wf___Оператор_объекдинения_с__NULL
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {FirstName ?? "нет данных"} | Имя: {MiddleName ?? "нет данных"} | Отчество: {SecondName ?? "нет данных"}";
        }

        public string GetPhoneNumber()
        {
            return $"Phone Number: {Contacts?.PhoneNumber ?? "нет данных"}";
        }
    }
}

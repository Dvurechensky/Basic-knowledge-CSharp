namespace Lesson_68___partial_класс__частичные_типы__partial_методы
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public partial void PrintFullName();//
    }
}

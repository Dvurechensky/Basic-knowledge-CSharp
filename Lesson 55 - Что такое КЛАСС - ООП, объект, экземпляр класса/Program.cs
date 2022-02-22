using System;

/*
 * ООП
 * класс
 * объект класса
 */

namespace Lesson_55___Что_такое_КЛАСС___ООП__объект__экземпляр_класса
{
    //будем хранить цвет точки
    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }

    //класс - это некий чертеж
    //класс - это наш собственный тип данных
    //класс - это ссылочный тип данных (мы должны выделить место в управляемой куче где он будет размещен)
    class Point
    {
        //Переменные внутри класса - называются поля со своими модификаторами доступа
        public int x;
        public int y;
        public Color color;
    }

    //*описали характеристики обьекта, шаблона этого класса
    //*главный плюс - можем вынести класс в отдельный файл - чтобы не городить код в одну кучу
    //*если лежит в том же namespace то можем видеть его, если нет то нужно внести using
    //class Student
    //{
    //    public Guid id; // - специальная структура для описания объекта, создания уникальных id
    //    public string firstName;
    //    public string lastName;
    //    public string middleName;
    //    public int age;
    //    public string group;
    //}

    class Program
    {
        static Students GetStudent()
        {
            return new Students
            {
                id = Guid.NewGuid(),
                firstName = "first",
                lastName = "last",
                middleName = "middle",
                age = 24,
                group = "professional"
            };
        }

        static void Print(Students student_val)
        {
            Console.WriteLine($"id: {student_val.id}, firstName: {student_val.firstName},\n" +
                              $"lastName: {student_val.lastName}, middleName: {student_val.middleName},\n" +
                              $"age: {student_val.age}, group: {student_val.group}");
        }

        //*Любой обьект в языке C# является наследником типа object
        static void Main(string[] args)
        {
            //экземпляр(объект) класса - это уже готовый построенный дом
            Point point_1 = new Point();
            point_1.x = 4;
            point_1.y = 2;

            Console.WriteLine($" x: {point_1.x}, y: {point_1.y }");

            Point point_2 = new Point();
            point_2.x = 2;
            point_2.y = 6;

            //Доказательство, того что класс - ссылочный тип
            Point test = new Point();
            test = null;
            //мы разорвали связь между данными в управляемой куче и объектом класса 
            //test.x = 4;
            //test.y = 2;

            Point point_3 = new Point();
            point_3.x = 4;
            point_3.y = 2;
            point_3.color = Color.Orange;
            Console.WriteLine($"X: {point_3.x} | Y: {point_3.y} | Color: {point_3.color}");

            //Student
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}

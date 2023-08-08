using System;

/*
 * Перегрузка конструкторов класса
 */

namespace Lesson_60___Перегрузка_конструкторов_класса__что_это
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthday = birthday;
        }

        public Student(Student student)
        {
            _firstName = student._firstName;
            _lastName = student._lastName;
            _middleName = student._middleName;
            _birthday = student._birthday;
        }

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: " + _firstName +
                $"\nФамилия: " + _lastName +
                $"\nОтчество: " + _middleName +
                $"\nДата рождения: " + _birthday);
        }
    }

    class Point
    {
        //наличие более одного конструктора и есть перегрузка 

        public Point()
        {
            _x = _y = 1;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x} \t Y: {_y}");
        }
    }

    class Program
    {
        static void Main()
        {
            Point point = new Point();
            point.Print();

            Student student_1 = new Student("lastName", DateTime.Now);

            //оба студента  - это ссылки в управляемой куче (особенность класса)
            //мы копируем ссылку студента 1 в обьект студента 2
            Student student_2 = student_1;

            //чтобы избежать копирования ссылки мы используем конструктор создания класса
            //тем самым конструируем новый объект
            Student student_3 = new Student(student_1);

            student_1.SetLastName("#####");
            student_3.SetLastName("***");

            student_1.Print();

            Console.WriteLine();

            student_2.Print();

            Console.WriteLine();

            student_3.Print();
        }
    }
}

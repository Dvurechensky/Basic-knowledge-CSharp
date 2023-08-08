using System;

/*
 * конструктор класса - это специальный метод класса, который вызывается при создании объекта такого класса (new)
 * 
 * конструктор по умолчанию
 */

namespace Lesson_59___Что_такое_конструктор_класса__для_чего__по_умолчанию
{
    class Point
    {
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

    class Gun
    {
        //ctor - конструктор по умолчанию
        //конструктор - тоже метод класса но только специальный, всегда public
        // можно выставить что сделать по умолчанию 

        //конструктор без параметров
        public Gun()
        {
            _isLoaded = true;
        }

        //конструктор с параметрами
        public Gun(bool isLoaded)
        {
            this._isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Reload() //поведение
        {
            Console.WriteLine("Заряжаю...");

            _isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }

            Console.WriteLine("Пыщ - Пыщ!\n");
            _isLoaded = false;
        }
    }
    class Program
    {
        static void Main()
        {
            Gun gun = new Gun(isLoaded: true); //new - конструктор по умолчанию (спец метод для создания объекта класса)
            gun.Shot();
            Point point = new Point(1, 3);
            point.Print();
        }
    }
}

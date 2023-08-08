using System;

/*
 * Сыойства (Properties)
 * 
 * Автоматические свойства
 */

namespace Lesson_62___Свойства_get__set_ключевое_слово_value__авто_свойства
{
    class Point
    {
        private int x;
        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }
    }


    class Program
    {
        static void Main()
        {
            Point point = new Point();
            point.SetX(5);
            Console.WriteLine(point.GetX());
        }
    }
}

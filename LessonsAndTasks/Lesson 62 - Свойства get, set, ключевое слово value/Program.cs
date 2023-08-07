using System;

/*
 * Свойства (Parametries)
 * 
 * Автоматические свойства
 */

namespace Lesson_62___Свойства_get__set__ключевое_слово_value
{
    class Point
    {
        private int x;

        public void SetX(int x)
        {
            //this.x = x;
            if(x < 1)
            {
                this.x = 1;
                return;
            }
            if(x > 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        //propfull - сниппет
        private int y;

        //get и set - это аксессоры (accessor)
        public int Y
        {
            get
            {
                return y;
            }
            set //(тут работают public set private) 
            {
                if(value < 1)
                {
                    y = 1;
                    return;
                }
                if(value > 5)
                {
                    y = 5;
                    return;
                }

                y = value;
            }
        }

        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        //автоматическое свойство - prop
        public int Z_auto { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(21);
            Console.WriteLine(point.GetX());
            point.Y = 10;
            Console.WriteLine(point.Y);
            point.Z_auto = 12;
            Console.WriteLine(point.Z_auto);
        }
    }
}

using System;

namespace Lesson_56___Методы_и_классы__ООП__вызов_метода_объекта_класса
{
    class Car
    {
        private int speed = 0;

        //пример инкапсуляции поля speed
        public void PrintSpeed()
        {
            if(speed == 0)
                Console.WriteLine("Стоим на месте");
            if(speed > 0)
                Console.WriteLine($"Едем вперед со скоростью {speed} км\\ч");
            if(speed < 0)
                Console.WriteLine($"Едем назад со скоростью {-speed} км\\ч");
        }

        public void DriveForward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -60;
        }
    }
}

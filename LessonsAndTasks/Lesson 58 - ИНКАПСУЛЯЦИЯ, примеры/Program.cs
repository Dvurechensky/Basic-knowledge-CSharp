using System;

/*
 * Инкапсуляция
 */

namespace Lesson_58___ИНКАПСУЛЯЦИЯ__примеры
{
    class Gun
    {
        private bool isLoaded; //состояние

        //инкапсуляция - скрываем состояние объекта - защищаем от внешнего мира
        //              и  даём возможность изменить состояние только с помощью этого же объекта

        // способ правильно организовать поведение(работу объекта через методы)

        private void Reload() //поведение
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shot()
        {
            if(!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }

            Console.WriteLine("Пыщ - Пыщ!\n");
            isLoaded = false;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shot();
        }
    }
}

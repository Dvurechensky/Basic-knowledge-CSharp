using System;

/*  Логические операторы
 *  
 *  
 *  &&      Сокращённое И
 *  ||      Сокращённое ИЛИ
 *  &       И
 *  |       ИЛИ
 *  !       НЕ(унарный)
 */

namespace Lesson_14___Сокращённые_логические_операции.Логические_операторы
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = true;

            if(isInfected)
            {
                Console.WriteLine("Персонаж инфицирован!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }

            //!
            isInfected = false;
            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован!");
            }

            //Не проверяет условия если одно уже равно необходимому значению
            //&&
            bool isHighTemperature = true;

            bool hasNoColing = true;

            if(isHighTemperature && hasNoColing)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            //||
            isHighTemperature = false;

            hasNoColing = true;

            if (isHighTemperature || hasNoColing)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            //Проверяет всегда оба выражения в условии
            //&
            isHighTemperature = true;

            hasNoColing = true;

            if (isHighTemperature & hasNoColing)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            //|
            isHighTemperature = false;

            hasNoColing = true;

            if (isHighTemperature | hasNoColing)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            //Разница работы операторов в отладчике
            if(GetTemperatue() | GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
            if (GetTemperatue() || GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
            if (GetTemperatue() & GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
            if (GetTemperatue() && GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
        }

        private static bool GetCoolingStatus()
        {
            return true;
        }

        private static bool GetTemperatue()
        {
            return true;
        }
    }
}

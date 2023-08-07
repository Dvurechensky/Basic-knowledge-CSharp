using System;

/*  Логические операторы
 *  
 *  &&      Сокращённое И
 *  ||      Сокращённое ИЛИ
 *  &       И
 *  |       ИЛИ
 *  !       НЕ(унарный)
 */
class Program
{
    static void Main()
    {
        bool isInfected = true;

        if (isInfected)
        {
            Console.WriteLine("[bool] Персонаж инфицирован!");
        }
        else
        {
            Console.WriteLine("[bool] Персонаж здоров!");
        }

        // Оператор "!"
        isInfected = false;
        if (!isInfected)
        {
            Console.WriteLine("[!] Персонаж здоров!");
        }
        else
        {
            Console.WriteLine("[!] Персонаж инфицирован!");
        }

        // Не проверяет условия если одно уже равно необходимому значению
        // Оператор "&&"
        bool isHighTemperature = true;

        bool hasNoColing = true;

        if (isHighTemperature && hasNoColing)
        {
            Console.WriteLine("[&&] Угроза повреждения процессора!!!");
        }

        // Оператор "||"
        isHighTemperature = false;

        hasNoColing = true;

        if (isHighTemperature || hasNoColing)
        {
            Console.WriteLine("[||] Угроза повреждения процессора!!!");
        }

        // Проверяет всегда оба выражения в условии
        // Оператор "&"
        isHighTemperature = true;

        hasNoColing = true;

        if (isHighTemperature & hasNoColing)
        {
            Console.WriteLine("[&] Угроза повреждения процессора!!!");
        }

        // Оператор "|"
        isHighTemperature = false;

        hasNoColing = true;

        if (isHighTemperature | hasNoColing)
        {
            Console.WriteLine("[|] Угроза повреждения процессора!!!");
        }

        // Разница работы операторов в отладчике
        // GetCoolingStatus = true, GetTemperatue = true
        if (GetTemperatue() | GetCoolingStatus())
        {
            Console.WriteLine("[|] Угроза повреждения процессора!!!");
        }
        if (GetTemperatue() || GetCoolingStatus())
        {
            Console.WriteLine("[|] Угроза повреждения процессора!!!");
        }
        if (GetTemperatue() & GetCoolingStatus())
        {
            Console.WriteLine("[&] Угроза повреждения процессора!!!");
        }
        if (GetTemperatue() && GetCoolingStatus())
        {
            Console.WriteLine("[&&] Угроза повреждения процессора!!!");
        }
        Console.ReadKey();
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
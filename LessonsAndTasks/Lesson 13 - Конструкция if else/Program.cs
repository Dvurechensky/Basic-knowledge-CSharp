using System;

/*
 * Конструкция if else
    if(утверждение или выражение)
    {
        действие 1;
    }
    else
    {
        действие 2;
    }
*/
class Program
{
    static void Main()
    {
        bool isInfected = true;

        if (isInfected)     // утверждение
        {
            Console.WriteLine("Персонаж инфицирован!");
        }
        else
        {
            Console.WriteLine("Персонаж не инфицирован!");
        }

        int a;

        int.TryParse(Console.ReadLine(), out a);

        if (a == 5)         // выражение
        {
            Console.WriteLine("a равно 5");
        }
        else
        {
            Console.WriteLine("a не равно 5");
        }

        //#Свой аналог
        Console.WriteLine(isInfected ? "Персонаж инфицирован!" : "Персонаж не инфицирован!");
        Console.ReadKey();
    }
}
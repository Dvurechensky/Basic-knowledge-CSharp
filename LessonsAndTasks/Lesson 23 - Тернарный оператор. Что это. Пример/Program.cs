using System;

/*
 * Тернарный оператор.
 * [первый операнд - условие]?[второй операнд if_true]:[третий операнд if_false]
 */
class Program
{
    static void Main()
    {
        int a = 0;

        a++;            //Унарная операция
        int b = 0;
        int c = a + b;  //Бинарная операция

        //Тернарная операция
        bool accessAllowed;
        string storedPassword = "qwerty";
        string enteredPassword = Console.ReadLine();

        if (enteredPassword == storedPassword)
            accessAllowed = true;
        else
            accessAllowed = false;

        Console.WriteLine(accessAllowed);

        Console.ReadLine();

        accessAllowed = enteredPassword == storedPassword ? true : false;

        Console.WriteLine(accessAllowed ? "успешно" : "не успешно");

        Console.ReadLine();

        accessAllowed = Console.ReadLine() == "qwerty";
        Console.WriteLine(accessAllowed ? "успешно" : "не успешно");

        Console.ReadLine();

        int inputData = int.Parse(Console.ReadLine());
        int outputData = inputData < 0 ? 0 : inputData;
        Console.WriteLine(outputData);

        Console.ReadKey();
    }
}
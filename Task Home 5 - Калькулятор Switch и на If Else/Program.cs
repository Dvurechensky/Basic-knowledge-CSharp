using System;

/*
 * пишем калькулятор C#
 */

namespace Task_Home_5___Калькулятор_Switch_и_на_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b, result;
                string action;

                try
                {
                    //if else
                    Console.WriteLine(value: "Введите первое число");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(value: "Введите первое число");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(value: "Действие + - % * /");
                    action = Console.ReadLine();
                    result = 0;

                    if (action == "+")
                    {
                        result = a + b;
                    }
                    else if (action == "-")
                    {
                        result = a - b;
                    }
                    else if (action == "%")
                    {
                        result = a % b;
                    }
                    else if (action == "*")
                    {
                        result = a * b;
                    }
                    else if (action == "/")
                    {
                        if (b == 0)
                            result = 0;
                        else
                            result = a / b;
                    } 
                    else
                    {
                        Console.WriteLine(Environment.NewLine + "Я не знаю!");
                    }

                    Console.WriteLine("Результат if else: " + result);

                    //switch
                    Console.WriteLine(Environment.NewLine + "Введите действие + - * % /" + Environment.NewLine);

                    ConsoleKey consoleKey = Console.ReadKey().Key;
                    switch (consoleKey)
                    {
                        case ConsoleKey.Add:
                        case ConsoleKey.OemPlus:
                            result = a + b;
                            break;
                        case ConsoleKey.Subtract:
                        case ConsoleKey.OemMinus:
                            result = a - b;
                            break;
                        case ConsoleKey.Multiply:
                            result = a * b;
                            break;
                        case ConsoleKey.Divide:
                            if (b == 0)
                                result = 0;
                            else
                                result = a / b;
                            break;
                        case ConsoleKey.D5:
                            result = a % b;
                            break;
                        default:
                            Console.WriteLine(Environment.NewLine + "Я не знаю!");
                            break;
                    }

                    Console.WriteLine(Environment.NewLine + "Результат switch: " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                    continue;
                }
               
                Console.ReadLine();
            }
            
        }
    }
}

using System;

/*
 * const и readonly
 */
class MyLogger
{
    public void Info(string message)
    {
        Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
    }

    public void Error(string message)
    {
        Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
    }

    public void Warn(string message)
    {
        Console.WriteLine($"{DateTime.Now}\t|WARN|\t{message}");
    }
}

class Car
{
    private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
    private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель!";
    private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Лапоть, двигатель уже запущен!";
    private const string ATTEMPT_TO_DRIVE_MESSAGE = "Тапку в пол!";
    private const string DRIVE_MESSAGE = "Поехали";
    private const string DRIVE_ERROR_MESSAGE = "Лапоть, сначала заведи двигатель";

    /// <summary>
    /// Это некий сервис который мы не будем менять
    /// использует класс Car под свои нужды
    /// </summary>
    private readonly MyLogger _myLogger;

    private bool isEngineStarted;

    public Car(MyLogger myLogger)
    {
        _myLogger = myLogger;
    }

    public void StartEngine()
    {
        _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
        if (isEngineStarted)
        {
            _myLogger.Warn(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
        }
        else
        {
            isEngineStarted = true;
            _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
        }
    }

    public void Drive()
    {
        _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
        if (isEngineStarted)
            _myLogger.Info(DRIVE_MESSAGE);
        else
            _myLogger.Error(DRIVE_ERROR_MESSAGE);
    }
}

class ConstReadonly
{
    /// <summary>
    /// const(не явно становится static)
    /// всегда должны помещать туда данные
    /// не изменяемое
    /// удобно для хранения сообщения об ошибках
    /// все константы - большими буквами
    /// позволяет избежать эффекта -магических чисел-
    /// </summary>
    public const double PI = 3.14;
    public const string MY_ERROR = "some error";

    /// <summary>
    /// readonly(НЕ static)
    /// изменяется только в конструкторе
    /// </summary>
    public readonly int _g = 1;
    /// <summary>
    /// можно сделать явно статическим
    /// можно использовать и менять только в статическом конструкторе
    /// </summary>
    public static readonly int _gg = 2;

    static ConstReadonly() => _gg = 43;

    public ConstReadonly(int g) => _g = g;

    public void Foo()
    {
        Console.WriteLine(PI);
        Console.WriteLine(MY_ERROR);
        Console.WriteLine(_g);
        Console.WriteLine(_gg);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(ConstReadonly._gg);
        Console.WriteLine(ConstReadonly.MY_ERROR);
        Console.WriteLine(ConstReadonly.PI);

        Car car = new Car(new MyLogger());
        car.Drive();
        car.StartEngine();
        car.StartEngine();
        car.Drive();
        Console.ReadKey();
    }
}

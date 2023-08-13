using System;
/*
 * явная реализация интерфейсов
 */
/// <summary>
/// *класс может реализовать интерфейсы с одинаковыми методами
/// *если нам нужна разная реализация для этих методов, то интерфейсы нужно реализовать явно 
/// </summary>
interface IFirstInterface
{
    void Action();
}

interface ISecondInterface
{
    void Action();
}

class Actions : IFirstInterface, ISecondInterface
{
    public void Action()
        => Console.WriteLine($"{GetType().Name}: Action");
}

/// <summary>
/// Для таких случаев нужно использовать явную реализацию интерфейсов
/// </summary>
class OtherAction : IFirstInterface, ISecondInterface
{
    /// <summary>
    /// Модификаторы ставить нельзя из-за неоднозначности и отсутствия ссылки на интерфейс
    /// </summary>
    void IFirstInterface.Action()
    {
        Console.WriteLine($"IFirstInterface Action");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine($"ISecondInterface Action");
    }
}

class Program
{
    static void Main()
    {
        var act = new Actions();

        Action_1(act);
        Action_2(act);

        var otherAction = new OtherAction();

        Action_1(otherAction);
        Action_2(otherAction);

        ((IFirstInterface)otherAction).Action();
        ((ISecondInterface)otherAction).Action();

        // более безопасный с операторами as или is
        if (otherAction is IFirstInterface firstInterface)
            firstInterface.Action();
        if (otherAction is ISecondInterface secondInterface)
            secondInterface.Action();
        Console.ReadKey();
    }

    public static void Action_1(IFirstInterface firstInterface)
        => firstInterface.Action();

    public static void Action_2(ISecondInterface secondInterface)
        => secondInterface.Action();
}
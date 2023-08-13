using System;
/*
 * полиморфизм
 * 
 * абстрактный класс
 * 
 * абстрактный метод
 * 
 * абстрактное свойство
 */
/// <summary>
/// Абстрактный класс - это некая идея, которая может содержать в себе частичную реализацию
/// и содержание которого можно использовать в наследниках
/// 
/// Из урока 77 делаем интерфейс ShowInfo
/// </summary>
interface IHasInfo
{
    void ShowInfo();
}

interface IWeapon
{
    int Damage { get; }
    void Fire();
}

/// <summary>
/// Cмысл абстрактного класса в том, что поведение одно единое для всех реализует интерфейс
/// а отдельные отличия поведения разного рода объектов реализует абстрактный класс
/// 
/// Хотим научить наш класс Player стрелять из любого вида оружия
/// </summary>
abstract class Weapon : IHasInfo, IWeapon
{
    public abstract int Damage { get; }
    /// <summary>
    /// Поведение
    /// </summary>
    public abstract void Fire();
    /// <summary>
    /// Не только абстрактный метод но и реализация возможна 
    /// </summary>
    public void ShowInfo() => Console.WriteLine($"{GetType().Name}: {Damage}");
}

/// <summary>
/// При наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
/// </summary>
class Gun : Weapon
{
    public override int Damage { get { return 5; } }

    public override void Fire()
        => Console.WriteLine("Boom");
}

/// <summary>
/// При наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
/// </summary>
class LazerGun : Weapon
{
    public override int Damage => 9;

    public override void Fire()
        => Console.WriteLine("Boom's");
}

/// <summary>
/// При наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
/// </summary>
class Bow : Weapon
{
    public override int Damage => 12;

    public override void Fire()
        => Console.WriteLine("Bzzzzzzzz");
}

class Box : IHasInfo
{
    public void ShowInfo() => Console.WriteLine("Я ЯЩИК!");
}

class Player
{
    public void Fire(IWeapon weapon) => weapon.Fire();
    public void CheckInfo(Weapon weapon) => weapon.ShowInfo();
    public void CheckInterfaceInfo(IHasInfo hasInfo) => hasInfo.ShowInfo();
}

class Program
{
    static void Main()
    {
        var player = new Player();
        Weapon[] inventory = { new Gun(), new LazerGun(), new Bow() };
        foreach (var item in inventory)
        {
            player.CheckInfo(item);
            player.CheckInterfaceInfo(item);
            player.Fire(item);
            Console.WriteLine();
        }
        player.CheckInterfaceInfo(new Box());
        Console.ReadKey();
    }
}
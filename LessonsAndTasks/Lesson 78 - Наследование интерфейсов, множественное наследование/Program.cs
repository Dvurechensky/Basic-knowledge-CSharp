using System;

/*
 * наследование интерфейсов
 */
interface IWeapon
{
    void Fire();
}

/// <summary>
/// Метательное оружие
/// </summary>
interface IThrowingWeapon : IWeapon
{
    void Throw();
}

/// <summary>
/// Принцип такой-же как у классов (все что есть в базовом доступно и в наследнике)
/// </summary>
interface ISmall : IWeapon { }

/// <summary>
/// В отличии от классов поддерживают множественное наследование
/// </summary>
interface IBig : IWeapon, ISmall { }

class Gun : IWeapon
{
    public void Fire()
        => Console.WriteLine($"{GetType().Name}: GunBom");
}

class LazerGun : IWeapon
{
    public void Fire()
        => Console.WriteLine($"{GetType().Name}: LazerGunBom");
}

class Bow : IWeapon// - это НЕ наследование, а реализация интерфейсов
{
    public void Fire()
        => Console.WriteLine($"{GetType().Name}: BowBom");
}

/// <summary>
/// Реализуем нож
/// </summary>
class Knife : IThrowingWeapon
{
    public void Fire()
        => Console.WriteLine($"{GetType().Name}: KnifeBom");

    public void Throw()
        => Console.WriteLine($"{GetType().Name}: KnifeThrow");
}

class Player
{
    public void Fire(IWeapon weapon) => weapon.Fire();

    public void Throw(IThrowingWeapon throwingWeapon)
        => throwingWeapon.Throw();
}

class Program
{
    static void Main()
    {
        ISmall small;
        var player = new Player();
        IWeapon[] inventory = { new Gun(), new LazerGun(), new Knife() };
        foreach (var item in inventory)
        {
            player.Fire(item);
            Console.WriteLine();
        }
        player.Throw(new Knife());
        Console.ReadKey();
    }
}
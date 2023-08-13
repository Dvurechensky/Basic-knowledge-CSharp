using System;

/*
 * структуры
 */
/*
 * !!! КОГДА использовать структуру а когда нет !!!!
 * Если в структуре нужно представить тип данных состоящий из примитивных типов
 * которые логически просто должны быть вместе (мало полей)(пример структура Vector из UNITY) 
 * (только в том случае если не нужно использовать полиморфизм
 * и наследование для этого типа данных) - выйгрыш в производительности
 * невелируем сборщик мусора
 */
/// <summary>
/// Структуры - это тоже самое что и класс, только
/// они являются значимым (а не ссылочным) типом и не имеют наследования (но ИНТЕРФЕЙСЫ имеют)
/// Классы - ссылочный тип (reference type - управляемая куча)
/// у классов есть Finalizer(как Деструктор)
/// </summary>
public class ClassPoint
{
    public ClassPoint() { }
    
    public int X { get; set; }
    public int Y { get; set; }
    public virtual void Print()
        => Console.WriteLine($"X: {X}, Y {Y}");
    /// <summary>
    /// Мы можем переопределить его работу в классе
    /// </summary>
    ~ClassPoint() { }
}

interface IInterface 
{
    void Print();
}

/// <summary>
/// Значимый тип (value types - стек, ссылки на значения - в куче) - но также может храниться в управляемой куче
/// не работают virtual override при наследовании, protected для свойств и методов
/// мы не можем переопределить работу Finalizer (аналог деструктора в классах)
/// не можем инициализировать поля или свойства напрямую, задать переменные
/// реализация ctor конструктора без параметров невозможна
/// </summary>
public struct StructPoint : IInterface
{
    public int X { get; set; }
    public int Y { get; set; }

    public StructPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Print() => Console.WriteLine($"X: {X}, Y {Y}");
}

class Program
{
    static void Foo(ClassPoint classPoint)
    {
        classPoint.X++;
        classPoint.Y++;
    }

    static void Bar(StructPoint structPoint)
    {
        structPoint.X++;
        structPoint.Y++;
    }

    static void Main()
    {
        // при инициализации нужно найти место в управляемой куче,
        // разместить там данные и получить на них ссылку - отсюда скорость работы выше
        // плюс для очистки мусора замедляется работа всей программы
        // инициализируем экземпляр класса в управляемую кучу
        var classPoint = new ClassPoint() { X = 2, Y = 3 }; 
        // практически нулевая скорость создания объекта структуры (там уже данные)
        // инициализируем поля структуры (помещает туда дефолтные значения)
        var structPoint = new StructPoint() { X = 3, Y = 2 }; 
        Foo(classPoint);    // тут передается ссылка (значения изменятся в экземпляре класса)
        Bar(structPoint);   // структуры передаются по значению (значения не изменятся в экземпляре структуры - без ref)
        IInterface myInterface = structPoint;
        classPoint.Print();
        myInterface.Print();

        // каким образом работает метод Equals при сравнении структур и классов
        var classPoint1 = new ClassPoint() { X = 2, Y = 3 };
        var classPoint2 = new ClassPoint() { X = 2, Y = 3 };

        bool classesAreEqual = classPoint1.Equals(classPoint2);     // false - по умолчанию сравнивает не значения, а ссылки
        Console.WriteLine($"Equals class: {classesAreEqual}");

        var structPoint1 = new StructPoint() { X = 2, Y = 3 };
        var structPoint2 = new StructPoint() { X = 2, Y = 3 };

        bool structesAreEqual = structPoint1.Equals(structPoint2);  // true - по умолчанию сравнивает значения, а не ссылки
        Console.WriteLine($"Equals struct: {structesAreEqual}");
        Console.ReadKey();
    }
}
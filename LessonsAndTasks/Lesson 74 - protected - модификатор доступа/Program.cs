using System;

/*
 * модификатор доступа protected при наследовании
 */
class Program
{
    public class A
    {
        public A()
        {
            Console.WriteLine("A");
            Console.WriteLine(publicField);      // поле доступно
            Console.WriteLine(protectedField);   // поле доступно
            Console.WriteLine(privateField);     // поле доступно
        }

        public void Bar()
        {
            Console.WriteLine("Bar");
            Console.WriteLine(publicField);     // поле доступно
            Console.WriteLine(protectedField);  // поле доступно
            Console.WriteLine(privateField);    // поле доступно
        }

        public int publicField = 4;
        private int privateField = 5;
        /// <summary>
        /// protected - работает со всем одинаково(свойства, поля, методы)
        /// protected - внутри класса доступны, снаружи класса не доступны (разница в наследовании)
        /// </summary>
        protected int protectedField = 6;
        private protected int privateprotectedField = 7;

        protected void Foo() { }
        protected int MyProperty { get; set; }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
            Console.WriteLine(publicField);     // поле доступно
            // Console.WriteLine(privateField); // поле не доступно в наследнике
            Console.WriteLine(protectedField);  // поле доступно в наследнике, но не доступно за пределами класса(или его наследников)
            Bar();
        }

        public void Cas()
        {
            Bar();
        }
    }

    static void Main()
    {
        A a = new A();
        Console.WriteLine(a.publicField);           // поле доступно
        //System.Console.WriteLine(a.protectedField)// поле не доступно из-за уровня защиты
        //System.Console.WriteLine(a.privateField)  // поле не доступно из-за уровня защиты
        B b = new B();
        Console.WriteLine(b.publicField);           // поле доступно
        //System.Console.WriteLine(b.protectedField)// поле не доступно из-за уровня защиты
        //System.Console.WriteLine(b.privateField)  // поле не доступно из-за уровня защиты
        b.Bar();
        Console.ReadKey();
    }
}
using System;

/*
 * Рекурсия
 * 
 * Методы и стек
 * 
 * Переполнение стека
 */

 /*
  * ДЗ 1
  * Реализовать вывод массива с помощью рекурсии
  * 
  * ДЗ 2
  * Найти сумму элементов массива с помощью рекурсии
  * 
  * ДЗ 3
  * Найти сумму цифр числа с помощью рекурсии Например - 561(число) = 12(сумма его чисел)
  */

namespace Lesson_49___Что_такое_рекурсия__переполнение_стека
{
    class Program
    {
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }


        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 5,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }

        static void Print(Item item)
        {
            if(item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }

        //Когда метод вызывает сам себя - рекурсия
        //Обязательно нужно предусматривать условие выхода из рекурсии
        //Недостаток - использовать можно только для коротких операций с малым числом переменных
        private static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
                return;
            i++;
            Foo(i);
        }

        static void Main(string[] args)
        {
            Foo(0);

            Item item = InitItem();

            Print(item);
            //или
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}

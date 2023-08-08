using System;

namespace Task_Home_4___Проверка_числа_на_чётность
{
    class Program
    {
        static void Main()
        {
            int a;

            a = int.Parse(Console.ReadLine());

            //int temp = a % 2;
            //bool result = temp == 1;

            if(a % 2 == 1)
            {
                Console.WriteLine("Не чётное");
            }
            else
            {
                Console.WriteLine("Чётное");
            }
        }
    }
}

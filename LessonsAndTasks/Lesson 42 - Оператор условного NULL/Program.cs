using System;
using System.Linq;

/*
 * Оператор условного NULL ?.
 */

namespace Lesson_42___Оператор_условного_NULL
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            // ?. - проверяет равна ли сумма null или не равна 
            // ?? - оператор объединения с null  
            Console.WriteLine(myArray?.Sum() ?? -1);
        }
    }
}

using System;

/*
 * Приоритет арифметических операций
 */
class Program
{
    static void Main()
    {
        int result = 2 + 2 * 2;
        int result1 = (2 + 2) * 2; // как и в математике обозначается "(" ")"

        Console.WriteLine(result);
        Console.WriteLine(result1);
        Console.ReadKey();
    }
}
using System;

/*
 * Вывод двумерного массива
 */
class Program
{
    static void Main()
    {
        int[,] myArray = new int[,]
        {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
                {13, 14, 15, 16 }
        };

        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //Число измерений массива - одномерный, двумерный и тд.
        Console.WriteLine(myArray.Rank);
        Console.WriteLine();

        //Суммарно число элементов в массиве.
        Console.WriteLine(myArray.Length);
        Console.WriteLine();

        //Количество элементов в конкретном измерении (измеряется с 0(1))
        Console.WriteLine(myArray.GetLength(1));
        Console.WriteLine();

        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {
                Console.Write(myArray[y, x] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
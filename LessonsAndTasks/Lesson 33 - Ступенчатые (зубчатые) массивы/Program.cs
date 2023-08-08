using System;

/*
 * Cтупенчатые (зубчатые) массивы 
 */
class Program
{
    static void Main()
    {
        int[][] test1 = new int[3][];
        int[,] test2 = new int[3, 6];

        int tes1Rank = test1.Rank;
        int test2Rank = test2.Rank;

        int tes1Lenght = test1.Length;
        int test2Lenght = test2.Length;

        test1[0] = new int[5];
        test1[1] = new int[8];
        test1[2] = new int[2];
        test1[0][2] = 6;
        Console.WriteLine(test1[0][2]);
        Random rnd = new Random();
        for (int i = 0; i < test1.Length; i++)
        {
            for (int k = 0; k < test1[i].Length; k++)
            {
                test1[i][k] = rnd.Next(100);
            }
        }

        for (int i = 0; i < test1.Length; i++)
        {
            for (int k = 0; k < test1[i].Length; k++)
            {
                Console.Write(test1[i][k] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
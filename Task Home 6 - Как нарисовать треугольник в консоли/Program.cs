using System;

/*
 * Треугольники в консоли
 */

namespace Task_Home_6___Как_нарисовать_треугольник_в_консоли
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввелите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int r = 0; r < height; r++)
            {
                for (int rr = 0; rr <= r; rr++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();

            for (int r = height; r > 0; r--)
            {
                for (int rr = 0; rr < r; rr++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int r = height; r > 0; r--)
            {
                for (int rr = 1; rr < r; rr++)
                {
                    Console.Write(" ");
                }

                for (int rrr = 0; rrr < (height + 1) - r; rrr++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            //Cheat
            Console.ReadLine();
            Console.Clear();

            for (int r = 1; r <= height; r++)
            {
                Console.SetCursorPosition(height - r, r - 1);

                for (int rrr = 0; rrr < r; rrr++)
                {
                    Console.Write("#");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            for (int r = 0; r < height; r++)
            {
                for (int rr = 0; rr < r; rr++)
                {
                    Console.Write(" ");
                }

                for (int rrr = 0; rrr < height - r; rrr++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

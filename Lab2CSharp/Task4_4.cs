using System;

namespace Lab2CSharp
{
    class Task4_4
    {
        public static void Run()
        {
            Console.Write("Введіть кількість рядків n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Помилка! Введіть коректне додатнє число.");
                return;
            }

            int[][] jaggedArray = new int[n][];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
                {
                    Console.WriteLine("Помилка! Введіть коректне додатнє число.");
                    return;
                }

                jaggedArray[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    jaggedArray[i][j] = rand.Next(-10, 20);
                }
            }

            Console.WriteLine("Східчастий масив:");
            foreach (var row in jaggedArray)
            {
                foreach (var item in row)
                    Console.Write(item + "\t");
                Console.WriteLine();
            }

            int maxColumns = 0;
            foreach (var row in jaggedArray)
            {
                if (row.Length > maxColumns)
                    maxColumns = row.Length;
            }

            int[] columnSums = new int[maxColumns];

            for (int j = 0; j < maxColumns; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j < jaggedArray[i].Length && jaggedArray[i][j] > 0 && jaggedArray[i][j] % 2 == 0)
                    {
                        columnSums[j] += jaggedArray[i][j];
                    }
                }
            }

            Console.WriteLine("\nСума парних додатних елементів у кожному стовпці:");
            foreach (var sum in columnSums)
            {
                Console.Write(sum + "\t");
            }
            Console.WriteLine();
        }
    }
}

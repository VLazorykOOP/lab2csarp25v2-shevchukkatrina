using System;

namespace Lab2CSharp
{
    class Task3_4
    {
        public static void Run()
        {
            Console.Write("Введіть розмірність матриці n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Помилка! Введіть коректне додатнє число.");
                return;
            }


            int[,] matrix = new int[n, n];
            Random rand = new Random();

            Console.WriteLine("Матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0, count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j > n - 1) 
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
            }

            double average = count > 0 ? (double)sum / count : 0;
            Console.WriteLine($"Середнє арифметичне елементів під побічною діагоналлю: {average:F2}");
        }
    }
}

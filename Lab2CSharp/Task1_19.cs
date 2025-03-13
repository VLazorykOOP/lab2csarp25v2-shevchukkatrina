using System;
using System.Text;

namespace Lab2CSharp
{
    class Task1_19
    {
        public static void Run()
        {
            Console.Write("Введіть розмірність одновимірного масиву (N): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некоректне введення! Введіть додатнє число.");
                return;
            }

            Console.Write("Введіть кількість стовпців для двовимірного масиву (N): ");
            if (!int.TryParse(Console.ReadLine(), out int p) || p <= 0)
            {
                Console.WriteLine("Некоректне введення! Введіть додатнє число.");
                return;
            }

            Console.Write("Введіть кількість рядків для двовимірного масиву (M): ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Некоректне введення! Введіть додатнє число.");
                return;
            }

            Console.WriteLine("\n--- Одновимірний масив ---");
            OneDimensionalArray(n);

            Console.WriteLine("\n--- Двовимірний масив ---");
            TwoDimensionalArray(p, m);
        }

        static void OneDimensionalArray(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();

            Console.WriteLine("\nМасив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nЕлементи з парними індексами:");
            for (int i = 0; i < n; i += 2) 
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void TwoDimensionalArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random rand = new Random();

            Console.WriteLine("\nЗгенерований масив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                    Console.Write(array[i, j].ToString().PadLeft(5) + " ");
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("\nЕлементи з парними індексами:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0) 
                    {
                        Console.Write(array[i, j].ToString().PadLeft(5) + " ");
                    }
                    else
                    {
                        Console.Write("     "); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

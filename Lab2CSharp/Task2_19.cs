using System;

namespace Lab2CSharp
{
    class Task2_19
    {
        public static void Run()
        {
            Console.Write("Введіть розмірність масиву: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rand = new Random();

            Console.WriteLine("Масив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(1, 50);
                Console.Write(array[i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] % array[i + 1] == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nКількість пар, де попередній елемент кратний наступному: {count}");
        }
    }
}

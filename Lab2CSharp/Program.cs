using System;
using System.Text;

namespace Lab2CSharp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Виберіть номер завдання(1, 2, 3, 4):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1_19.Run();
                    break;
                case "2":
                    Task2_19.Run();
                    break;
                case "3":
                    Task3_4.Run();
                    break;
                case "4":
                    Task4_4.Run();
                    break;
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
        }
    }
}

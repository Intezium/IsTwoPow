using System;

namespace IsTwoPow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===>[Проверка на степень двойки]<===");
                Console.Write("\nВведите число: ");

                try
                {
                    int number = int.Parse(Console.ReadLine());

                    IsTwoPow(number);
                }
                catch (FormatException) { Console.WriteLine("\nНекорректное число!"); }

                Console.WriteLine("\nEnter - Проверить еще");
                Console.WriteLine("Esc - Выйти");

                ConsoleKey inputKey = Console.ReadKey().Key;

                if (inputKey == ConsoleKey.Enter)
                    continue;
                else if (inputKey == ConsoleKey.Escape)
                    break;
            }
        }

        static void IsTwoPow(int number)
        {
            if (number != 0 && ((number) & (number - 1)) == 0)
                Console.WriteLine("\nЧисло {0} степень двойки", number);
            else
                Console.WriteLine("\nЧисло {0} не степень двойки", number);
        }
    }
}

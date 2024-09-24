using System;

class Zadanie3
{
    static void Run()
    {
        // Вводим значение K
        Console.Write("Введите количество простых чисел K: ");
        int K = int.Parse(Console.ReadLine());

        // Переменные для хранения найденных простых чисел и текущего числа
        int count = 0;
        int number = 2;

        // Пока не найдено K простых чисел
        while (count < K)
        {
            if (IsPrime(number)) // Проверяем, является ли текущее число простым
            {
                Console.Write($"{number} ");
                count++;

                // Переход на новую строку после каждых 10 чисел
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            number++;
        }
    }

    // Метод для проверки, является ли число простым
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

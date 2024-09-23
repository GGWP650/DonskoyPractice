using System;

class Zadanie4
{
    static void Run()
    {
        // Создание объекта для генерации случайных чисел
        Random random = new Random();
        // Инициализация массива из 20 элементов
        int[] numbers = new int[20];

        // Заполнение массива случайными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // Числа от 1 до 100
        }

        // Вывод сгенерированного массива
        Console.WriteLine("Массив случайных чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Поиск максимального и минимального значения
        int maxValue = numbers[0];
        int minValue = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        // Вывод результата
        Console.WriteLine("\n\nМаксимальное значение: " + maxValue);
        Console.WriteLine("Минимальное значение: " + minValue);
    }
}

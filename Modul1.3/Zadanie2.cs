using System;

class Zadanie2
{
    static void Run()
    {
        // Вводим ограничение на сумму
        Console.Write("Введите максимальную сумму элементов массива: ");
        int maxSum = int.Parse(Console.ReadLine());

        // Инициализация генератора случайных чисел
        Random random = new Random();

        // Создаём список для хранения элементов массива
        var elements = new System.Collections.Generic.List<int>();
        int currentSum = 0;

        // Добавляем случайные числа до тех пор, пока сумма не превысит maxSum
        while (currentSum < maxSum)
        {
            int randomNumber = random.Next(1, 10); // Случайное число от 1 до 9
            if (currentSum + randomNumber > maxSum)
            {
                break; // Прерываем, если добавление числа превысит максимальную сумму
            }

            elements.Add(randomNumber);
            currentSum += randomNumber;
        }

        // Выводим массив и его сумму
        Console.WriteLine("Полученный массив:");
        foreach (int element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов: {currentSum}");
    }
}

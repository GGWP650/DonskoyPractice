using System;

class Zadanie4
{
    static void Run()
    {
        // Вводим размер массива K и границы диапазона A и B
        Console.Write("Введите количество элементов массива K: ");
        int K = int.Parse(Console.ReadLine());

        Console.Write("Введите значение A (начало диапазона): ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение B (конец диапазона, исключается): ");
        int B = int.Parse(Console.ReadLine());

        // Инициализируем массив и присваиваем случайные значения
        int[] array = new int[K];
        Random random = new Random();

        for (int i = 0; i < K; i++)
        {
            array[i] = random.Next(A, B); // Генерация случайного значения в диапазоне [A, B)
        }

        // Выводим сгенерированные элементы массива
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < K; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Находим индексы минимального и максимального элементов
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < K; i++)
        {
            if (array[i] < array[minIndex]) minIndex = i;
            if (array[i] > array[maxIndex]) maxIndex = i;
        }

        // Определяем начальный и конечный индексы для вывода значений между минимальным и максимальным
        int startIndex = Math.Min(minIndex, maxIndex);
        int endIndex = Math.Max(minIndex, maxIndex);

        // Выводим значения элементов между минимальным и максимальным (включая их)
        Console.WriteLine("Элементы между минимальным и максимальным (включительно):");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

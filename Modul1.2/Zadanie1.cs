using System;

class Zadanie1
{
    static void Main()
    {
        // Вводим размер массива
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine());

        // Создаем массив и заполняем его элементами
        double[] array = new double[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Введите элемент массива [{i}]: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        // Находим максимальный по модулю элемент массива
        double maxAbsElement = array.Max(Math.Abs);

        if (maxAbsElement == 0)
        {
            Console.WriteLine("Невозможно нормировать массив, максимальный элемент равен нулю.");
            return;
        }

        // Нормируем элементы массива
        for (int i = 0; i < N; i++)
        {
            array[i] /= maxAbsElement;
        }

        // Выводим значения нормированных элементов
        Console.WriteLine("Нормированные элементы массива:");
        foreach (double value in array)
        {
            Console.WriteLine(value);
        }
    }
}

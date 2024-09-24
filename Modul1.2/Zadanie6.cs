using System;
using System.Linq;

class Zadanie6
{
    static void Run()
    {
        // Определяем вещественный массив из 10 элементов
        double[] array = new double[10];
        Random random = new Random();

        // Заполняем массив случайными значениями в диапазоне [-10, 10)
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * 20 - 10; // Генерируем значения в диапазоне [-10, 10)
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        foreach (double value in array)
        {
            Console.WriteLine(value);
        }

        // Формируем массив индексов в порядке возрастания значений элементов
        int[] indexArray = array
            .Select((value, index) => new { value, index }) // Создаем пары { значение, индекс }
            .OrderBy(x => x.value) // Сортируем по значению
            .Select(x => x.index) // Извлекаем индексы
            .ToArray();

        // Выводим массив индексов
        Console.WriteLine("Массив индексов, упорядочивающий элементы по возрастанию:");
        foreach (int index in indexArray)
        {
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}

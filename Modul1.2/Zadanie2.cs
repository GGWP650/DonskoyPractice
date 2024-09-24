using System;

class Zadanie2
{
    static void Run()
    {
        // Инициализируем целочисленный массив из 10 элементов
        int[] array = { 1, 5, 8, 3, 6, 9, 2, 7, 4, 0 };

        // Выводим текущие значения массива
        Console.WriteLine("Текущие элементы массива:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        // Вводим целое число для замены
        Console.Write("Введите целое число для замены максимального элемента: ");
        int newValue = int.Parse(Console.ReadLine());

        // Находим индекс максимального элемента
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        // Заменяем максимальный элемент введенным числом
        array[maxIndex] = newValue;

        // Выводим измененные значения массива
        Console.WriteLine("Измененные элементы массива:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

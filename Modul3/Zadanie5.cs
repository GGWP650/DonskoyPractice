using System;

public delegate void SortDelegate(int[] array);

public class SortingAlgorithms
{
    // Метод сортировки пузырьком
    public static void BubbleSort(int[] array)
    {
        Console.WriteLine("Сортировка пузырьком:");
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен значениями
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Метод быстрой сортировки
    public static void QuickSort(int[] array)
    {
        Console.WriteLine("Быстрая сортировка:");
        QuickSortHelper(array, 0, array.Length - 1);
    }

    // Вспомогательный метод для быстрой сортировки
    private static void QuickSortHelper(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortHelper(array, low, pivotIndex - 1);
            QuickSortHelper(array, pivotIndex + 1, high);
        }
    }

    // Метод разбиения для быстрой сортировки
    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                // Обмен значениями
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Обмен опорного элемента с элементом на позиции i + 1
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }

    // Метод для вывода массива
    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}

public class Zadanie5
{
    public static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2, 7, 1, 6 };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        SortingAlgorithms.PrintArray(numbers);

        // Выбор метода сортировки
        Console.WriteLine("Выберите метод сортировки:\n1. Сортировка пузырьком\n2. Быстрая сортировка");
        int choice = int.Parse(Console.ReadLine());

        SortDelegate sortMethod;

        switch (choice)
        {
            case 1:
                sortMethod = SortingAlgorithms.BubbleSort;
                break;

            case 2:
                sortMethod = SortingAlgorithms.QuickSort;
                break;

            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        // Сортировка массива
        sortMethod(numbers);

        // Вывод отсортированного массива
        Console.WriteLine("Отсортированный массив:");
        SortingAlgorithms.PrintArray(numbers);
    }
}

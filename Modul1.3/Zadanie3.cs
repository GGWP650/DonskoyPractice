using System;
using System.Linq;

class Zadanie3
{
    static void Run()
    {
        // Ввод размера квадратной матрицы
        Console.Write("Введите размер квадратной матрицы (N): ");
        int N = int.Parse(Console.ReadLine());

        // Инициализируем генератор случайных чисел
        Random random = new Random();

        // Создаем квадратную матрицу NxN
        int[,] matrix = new int[N, N];

        // Заполняем матрицу случайными значениями в диапазоне от -50 до 50
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(-50, 51); // Значения от -50 до 50 включительно
            }
        }

        // Выводим исходную матрицу
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, N);

        // Упорядочиваем строки матрицы по возрастанию сумм их элементов
        var sortedMatrix = matrix
            .Cast<int>() // Преобразуем двумерный массив в одномерный
            .Select((value, index) => new { Row = index / N, Col = index % N, Value = value })
            .GroupBy(x => x.Row)
            .OrderBy(row => row.Sum(x => x.Value)) // Упорядочиваем строки по сумме их элементов
            .SelectMany(group => group.Select(x => x.Value)) // Преобразуем обратно в одномерный массив
            .ToArray();

        // Преобразуем обратно в двумерную матрицу
        int[,] resultMatrix = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                resultMatrix[i, j] = sortedMatrix[i * N + j];
            }
        }

        // Выводим упорядоченную матрицу
        Console.WriteLine("\nУпорядоченная матрица:");
        PrintMatrix(resultMatrix, N);
    }

    // Метод для вывода матрицы
    static void PrintMatrix(int[,] matrix, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

using System;

class Zadanie5
{
    static void Run()
    {
        // Вводим значение K
        Console.Write("Введите количество элементов массива K: ");
        int K = int.Parse(Console.ReadLine());

        // Определяем русский алфавит
        char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' }; // Гласные буквы
        Random random = new Random();

        // Создаем массив случайных русских букв
        char[] charArray = new char[K];
        for (int i = 0; i < K; i++)
        {
            charArray[i] = russianAlphabet[random.Next(russianAlphabet.Length)];
        }

        // Выводим первый массив
        Console.WriteLine("Исходный массив:");
        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        // Создаем новый массив с согласными буквами
        char[] consonantsArray = Array.FindAll(charArray, c => Array.IndexOf(vowels, c) == -1);

        // Выводим массив с согласными буквами
        Console.WriteLine("Массив с согласными буквами:");
        foreach (char c in consonantsArray)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}

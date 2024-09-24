using System;

class Zadanie1
{
    static void Main()
    {
        // Ввод числителя и знаменателя
        Console.Write("Введите неотрицательный числитель: ");
        int numerator = int.Parse(Console.ReadLine());

        Console.Write("Введите положительный знаменатель: ");
        int denominator = int.Parse(Console.ReadLine());

        if (denominator == 0)
        {
            Console.WriteLine("Знаменатель не может быть равен 0.");
            return;
        }

        // Вычисляем НОД
        int gcd = GreatestCommonDivisor(numerator, denominator);

        // Сокращаем дробь
        int reducedNumerator = numerator / gcd;
        int reducedDenominator = denominator / gcd;

        // Выводим сокращенную дробь
        Console.WriteLine($"Сокращенная дробь: {reducedNumerator}/{reducedDenominator}");
    }

    // Метод для нахождения НОД (алгоритм Евклида)
    static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

using System;

class Zadanie1
{
    static void Main()
    {
        // Чтение введенной строки с консоли, преобразование её в целое число и сохранение в переменную number
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка, делится ли число на 2 без остатка
        if (number % 2 == 0)
        {
            Console.WriteLine("Число четное.");
        }
        else
        {
            Console.WriteLine("Число нечетное.");
        }
    }
}

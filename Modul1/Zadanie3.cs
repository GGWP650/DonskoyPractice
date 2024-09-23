using System;

class Zadanie3
{
    static void Run()
    {
        // Запрос имени у пользователя
        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();

        // Запрос фамилии у пользователя
        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine();

        // Вывод результата в формате "Фамилия, Имя"
        Console.WriteLine($"{lastName}, {firstName}");
    }
}

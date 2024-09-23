using System;

class Zadanie5
{
    static void Run()
    {
        // Запрос возраста у пользователя
        Console.Write("Введите ваш возраст: ");
        int age;

        // Проверка корректности введенных данных
        if (int.TryParse(Console.ReadLine(), out age))
        {
            // Проверка возраста для получения водительских прав
            if (age >= 18)
            {
                Console.WriteLine("Вы можете получить водительские права.");
            }
            else
            {
                Console.WriteLine("Вы еще не можете получить водительские права.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное число.");
        }
    }
}

using System;

class Zadanie2
{
    static void Run()
    {
        // Запрос радиуса у пользователя
        Console.Write("Введите радиус круга: ");
        string input = Console.ReadLine();

        // Попытка преобразовать введённые данные в число с плавающей запятой
        if (double.TryParse(input, out double radius) && radius > 0)
        {
            // Вычисление площади круга
            double area = Math.PI * Math.Pow(radius, 2);

            // Вывод результата
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {area:F2}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число.");
        }
    }
}

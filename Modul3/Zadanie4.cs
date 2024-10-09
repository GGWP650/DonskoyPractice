using System;
using System.Collections.Generic;

// Делегат для фильтрации данных
public delegate bool FilterDelegate(DataItem item);

// Класс для представления данных
public class DataItem
{
    public string Title { get; set; }
    public DateTime Date { get; set; }

    public DataItem(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }
}

// Класс для фильтрации данных
public class DataFilter
{
    // Метод для фильтрации данных по заданному делегату
    public List<DataItem> Filter(List<DataItem> dataItems, FilterDelegate filter)
    {
        List<DataItem> filteredItems = new List<DataItem>();
        foreach (var item in dataItems)
        {
            if (filter(item))
            {
                filteredItems.Add(item);
            }
        }
        return filteredItems;
    }
}

public class Zadanie4
{
    public static void Run()
    {
        // Создание списка данных
        List<DataItem> dataItems = new List<DataItem>
        {
            new DataItem("Событие 1", new DateTime(2024, 10, 1)),
            new DataItem("Событие 2", new DateTime(2024, 10, 2)),
            new DataItem("Событие 3", new DateTime(2024, 10, 3)),
            new DataItem("Событие 4", new DateTime(2024, 9, 30)),
            new DataItem("Важное событие", new DateTime(2024, 10, 5)),
        };

        DataFilter filter = new DataFilter();

        Console.WriteLine("Выберите фильтр:\n1. Фильтр по ключевым словам\n2. Фильтр по дате");
        int choice = int.Parse(Console.ReadLine());

        List<DataItem> filteredItems = new List<DataItem>();

        switch (choice)
        {
            case 1:
                // Фильтрация по ключевым словам
                Console.WriteLine("Введите ключевое слово:");
                string keyword = Console.ReadLine();
                FilterDelegate keywordFilter = (item) => item.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase);
                filteredItems = filter.Filter(dataItems, keywordFilter);
                break;

            case 2:
                // Фильтрация по дате
                Console.WriteLine("Введите дату (ГГГГ-ММ-ДД):");
                DateTime filterDate = DateTime.Parse(Console.ReadLine());
                FilterDelegate dateFilter = (item) => item.Date.Date == filterDate.Date;
                filteredItems = filter.Filter(dataItems, dateFilter);
                break;

            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        // Вывод отфильтрованных данных
        Console.WriteLine("Отфильтрованные данные:");
        foreach (var item in filteredItems)
        {
            Console.WriteLine($"- {item.Title} (Дата: {item.Date.ToShortDateString()})");
        }
    }
}

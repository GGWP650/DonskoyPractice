using System;
using System.Collections.Generic;

// Делегат для выполнения задачи
public delegate void TaskDelegate(string taskName);

// Класс для управления задачами
public class TaskManager
{
    // Список задач
    private List<(string taskName, TaskDelegate taskAction)> tasks = new List<(string, TaskDelegate)>();

    // Добавление задачи с выбранным действием (делегатом)
    public void AddTask(string taskName, TaskDelegate taskAction)
    {
        tasks.Add((taskName, taskAction));
    }

    // Выполнение всех задач
    public void ExecuteTasks()
    {
        foreach (var task in tasks)
        {
            task.taskAction?.Invoke(task.taskName); // Вызов делегата для выполнения задачи
        }
    }
}

// Логгер для записи задач в журнал
public class Logger
{
    public void LogTask(string taskName)
    {
        Console.WriteLine($"Задача '{taskName}' записана в журнал.");
    }
}

// Уведомления для отправки уведомлений по задаче
public class Notifier
{
    public void NotifyTask(string taskName)
    {
        Console.WriteLine($"Отправлено уведомление по задаче: '{taskName}'.");
    }
}

public class Zadanie3
{
    public static void Run()
    {
        TaskManager taskManager = new TaskManager();
        Logger logger = new Logger();
        Notifier notifier = new Notifier();

        while (true)
        {
            Console.WriteLine("\nВведите название задачи:");
            string taskName = Console.ReadLine();

            Console.WriteLine("Выберите действие для задачи:\n1. Записать в журнал\n2. Отправить уведомление\n3. И то, и другое");
            int choice = int.Parse(Console.ReadLine());

            TaskDelegate taskAction = null;

            switch (choice)
            {
                case 1:
                    taskAction = new TaskDelegate(logger.LogTask); // Явное создание экземпляра делегата
                    break;
                case 2:
                    taskAction = new TaskDelegate(notifier.NotifyTask); // Явное создание экземпляра делегата
                    break;
                case 3:
                    // Явное создание экземпляров делегатов и их объединение
                    taskAction = new TaskDelegate(logger.LogTask) + new TaskDelegate(notifier.NotifyTask);
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    continue;
            }

            // Добавление задачи с выбранным действием
            taskManager.AddTask(taskName, taskAction);

            Console.WriteLine("Задача добавлена. Хотите добавить ещё одну задачу? (y/n)");
            string continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("\nВыполняются все задачи:");
        taskManager.ExecuteTasks();
    }
}

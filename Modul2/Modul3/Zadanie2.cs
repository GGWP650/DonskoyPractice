using System;

// Делегат для уведомлений
public delegate void NotificationEventHandler(string message);

// Класс "Уведомление"
public class Notification
{
    // Событие для уведомления о сообщении
    public event NotificationEventHandler MessageSent;

    // Событие для уведомления о звонке
    public event NotificationEventHandler CallReceived;

    // Событие для уведомления о новом электронном письме
    public event NotificationEventHandler EmailReceived;

    // Метод для отправки сообщения
    public void SendMessage(string message)
    {
        Console.WriteLine("Отправка сообщения...");
        OnMessageSent(message);
    }

    // Метод для получения звонка
    public void ReceiveCall(string caller)
    {
        Console.WriteLine("Получен звонок от " + caller + "...");
        OnCallReceived("Звонок от: " + caller);
    }

    // Метод для получения электронного письма
    public void ReceiveEmail(string email)
    {
        Console.WriteLine("Получено новое письмо...");
        OnEmailReceived("Новое письмо от: " + email);
    }

    // Виртуальные методы для вызова событий
    protected virtual void OnMessageSent(string message)
    {
        MessageSent?.Invoke(message);
    }

    protected virtual void OnCallReceived(string message)
    {
        CallReceived?.Invoke(message);
    }

    protected virtual void OnEmailReceived(string message)
    {
        EmailReceived?.Invoke(message);
    }
}

// Класс, который будет обрабатывать уведомления
public class NotificationHandler
{
    // Метод для обработки сообщений
    public void OnMessageSent(string message)
    {
        Console.WriteLine($"Уведомление: {message}");
    }

    // Метод для обработки звонков
    public void OnCallReceived(string message)
    {
        Console.WriteLine($"Уведомление: {message}");
    }

    // Метод для обработки электронных писем
    public void OnEmailReceived(string message)
    {
        Console.WriteLine($"Уведомление: {message}");
    }
}

public class Zadanie2
{
    public static void Run()
    {
        Notification notification = new Notification();
        NotificationHandler handler = new NotificationHandler();

        // Регистрация обработчиков событий
        notification.MessageSent += handler.OnMessageSent;
        notification.CallReceived += handler.OnCallReceived;
        notification.EmailReceived += handler.OnEmailReceived;

        // Вызов методов для отправки уведомлений
        notification.SendMessage("Ваше сообщение успешно отправлено!");
        notification.ReceiveCall("Maxim");
        notification.ReceiveEmail("ggwp650@gmail.com");
    }
}

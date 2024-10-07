using System;

public class Person
{
    // Поля класса
    private string name;
    private int age;
    private string address;

    // Конструктор класса
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Методы для установки значений
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным.");
        }
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    // Методы для получения значений
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetAddress()
    {
        return address;
    }

    // Метод для вывода информации о человеке
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Адрес: {address}");
    }
}

class Zadanie1
{
    static void Run(string[] args)
    {
        // Создание объектов класса Person
        Person person1 = new Person("Алексей", 30, "Москва, ул. Ленина, д.1");
        Person person2 = new Person("Мария", 25, "Санкт-Петербург, ул. Пушкина, д.100");

        // Вывод информации о людях
        person1.PrintInfo();
        person2.PrintInfo();
    }
}
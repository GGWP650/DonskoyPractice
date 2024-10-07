using System;

public class Author
{
    // Поля для имени и года рождения автора
    private string name;
    private int birthYear;

    // Конструктор для инициализации полей
    public Author(string name, int birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
    }

    // Метод для получения информации об авторе
    public string GetAuthorInfo()
    {
        return $"{name}, {birthYear} года рождения";
    }
}

public class Book
{
    // Поля для названия, года выпуска и автора (композиция)
    private string title;
    private int publishYear;
    private Author author;

    // Конструктор для инициализации полей
    public Book(string title, int publishYear, Author author)
    {
        this.title = title;
        this.publishYear = publishYear;
        this.author = author;
    }

    // Метод для получения информации о книге
    public void PrintBookInfo()
    {
        Console.WriteLine($"Название: {title}, Год выпуска: {publishYear}");
        Console.WriteLine($"Автор: {author.GetAuthorInfo()}");
    }
}

class Zadanie3
{
    static void Run(string[] args)
    {
        // Создание объектов класса Author
        Author author1 = new Author("Лев Толстой", 1828);
        Author author2 = new Author("Фёдор Достоевский", 1821);

        // Создание объектов класса Book с использованием объектов Author
        Book book1 = new Book("Война и мир", 1869, author1);
        Book book2 = new Book("Преступление и наказание", 1866, author2);

        // Вывод информации о книгах и их авторах
        book1.PrintBookInfo();
        Console.WriteLine();
        book2.PrintBookInfo();
    }
}

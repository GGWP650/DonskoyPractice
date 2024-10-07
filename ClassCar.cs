using System;

public class Car
{
    // Поля для марки, модели, года выпуска и цены
    private string brand;
    private string model;
    private int year;
    private double price;

    // Конструктор
    public Car(string brand, string model, int year, double price)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.price = price;
    }

    // Метод для расчета стоимости с учетом скидки
    public double CalculatePriceWithDiscount(double discount)
    {
        double discountedPrice = price - (price * discount / 100);
        return discountedPrice;
    }

    // Метод для расчета стоимости с учетом налога
    public double CalculatePriceWithTax(double taxRate)
    {
        double priceWithTax = price + (price * taxRate / 100);
        return priceWithTax;
    }

    // Метод для вывода информации об автомобиле
    public void PrintInfo()
    {
        Console.WriteLine($"Марка: {brand}, Модель: {model}, Год выпуска: {year}, Цена: {price:C}");
    }
}

class Cars
{
    static void Run(string[] args)
    {
        // Создание объекта автомобиля
        Car car = new Car("Toyota", "Camry", 2021, 30000);

        // Вывод информации
        car.PrintInfo();

        // Расчет стоимости с учетом скидки 10% и налога 18%
        double discountedPrice = car.CalculatePriceWithDiscount(10);
        double priceWithTax = car.CalculatePriceWithTax(18);

        Console.WriteLine($"Цена со скидкой: {discountedPrice:C}");
        Console.WriteLine($"Цена с налогом: {priceWithTax:C}");
    }
}

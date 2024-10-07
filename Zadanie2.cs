using System;

public abstract class Shape
{
    // Абстрактные методы для площади и периметра
    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Переопределение метода для вычисления площади круга
    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    // Переопределение метода для вычисления периметра (длины окружности)
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Переопределение метода для вычисления площади прямоугольника
    public override double Area()
    {
        return width * height;
    }

    // Переопределение метода для вычисления периметра прямоугольника
    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Zadanie2
{
    static void Run(string[] args)
    {
        // Создание объектов классов Circle и Rectangle
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        // Вывод площади и периметра для круга
        Console.WriteLine($"Круг с радиусом 5.0:");
        Console.WriteLine($"Площадь: {circle.Area()}");
        Console.WriteLine($"Периметр: {circle.Perimeter()}");

        // Вывод площади и периметра для прямоугольника
        Console.WriteLine($"\nПрямоугольник с шириной 4.0 и высотой 6.0:");
        Console.WriteLine($"Площадь: {rectangle.Area()}");
        Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
    }
}

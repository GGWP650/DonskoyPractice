using System;

// Делегат для вычисления площади
public delegate double AreaDelegate();

// Базовый класс "Фигура"
public abstract class Figure
{
    // Виртуальный метод для вычисления площади
    public abstract double CalculateArea();
}

// Класс "Круг"
public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Переопределенный метод для вычисления площади круга
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Класс "Прямоугольник"
public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Переопределенный метод для вычисления площади прямоугольника
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Класс "Треугольник"
public class Triangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    // Переопределенный метод для вычисления площади треугольника
    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

public class Zadanie1
{
    public static void Run()
    {
        // Создаем экземпляры фигур
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(3, 7);

        // Используем делегаты для вычисления площади
        AreaDelegate circleAreaDelegate = new AreaDelegate(circle.CalculateArea);
        AreaDelegate rectangleAreaDelegate = new AreaDelegate(rectangle.CalculateArea);
        AreaDelegate triangleAreaDelegate = new AreaDelegate(triangle.CalculateArea);

        // Вывод результатов
        Console.WriteLine($"Площадь круга: {circleAreaDelegate()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangleAreaDelegate()}");
        Console.WriteLine($"Площадь треугольника: {triangleAreaDelegate()}");
    }
}

using System;

// Определение пространства имен
namespace Shapes
{
    // Интерфейс IDrawable с методом Draw()
    public interface IDrawable
    {
        void Draw();
    }

    // Класс Circle, реализующий интерфейс IDrawable
    public class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисую круг с радиусом {radius}");
        }
    }

    // Класс Rectangle, реализующий интерфейс IDrawable
    public class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисую прямоугольник шириной {width} и высотой {height}");
        }
    }

    // Класс Triangle, реализующий интерфейс IDrawable
    public class Triangle : IDrawable
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисую треугольник с основанием {baseLength} и высотой {height}");
        }
    }
}

// Основной класс программы
class Zadanie4
{
    static void Run()
    {
        // Создаем массив объектов, реализующих интерфейс IDrawable
        Shapes.IDrawable[] shapes = new Shapes.IDrawable[]
        {
            new Shapes.Circle(5),
            new Shapes.Rectangle(10, 20),
            new Shapes.Triangle(15, 30)
        };

        // Вызываем метод Draw() для каждого объекта
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}

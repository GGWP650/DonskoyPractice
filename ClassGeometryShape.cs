using System;

namespace GeometricShapes
{
    // Абстрактный класс "Геометрическая фигура"
    public abstract class Shape
    {
        // Абстрактный метод для вычисления площади
        public abstract double CalculateArea();
    }

    // Класс "Круг"
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // Площадь круга
        }
    }

    // Класс "Прямоугольник"
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height; // Площадь прямоугольника
        }
    }

    // Класс "Треугольник"
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height; // Площадь треугольника
        }
    }

    // Тестирование классов
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5); // Создаем объект круга
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

            Shape rectangle = new Rectangle(4, 6); // Создаем объект прямоугольника
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");

            Shape triangle = new Triangle(4, 5); // Создаем объект треугольника
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        }
    }
}

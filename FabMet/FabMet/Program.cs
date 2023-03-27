using System;
using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace FabMet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення фабрик для круга, прямокутника та трикутника
            ShapeFactory circleFactory = new CircleFactory(5);
            ShapeFactory rectangleFactory = new RectangleFactory(10, 5);
            ShapeFactory triangleFactory = new TriangleFactory(6, 4);

            // Створення фігур з використанням фабрик
            Shape circle = circleFactory.CreateShape();
            Shape rectangle = rectangleFactory.CreateShape();
            Shape triangle = triangleFactory.CreateShape();

            // Виведення площ фігур
            Console.WriteLine($"Площа круга з радіусом 5: {circle.GetArea()}");
            Console.WriteLine($"Площа прямокутника з довжиною 10 та шириною 5: {rectangle.GetArea()}");
            Console.WriteLine($"Площа трикутника з основою 6 та висотою 4: {triangle.GetArea()}");
        }
    }

}
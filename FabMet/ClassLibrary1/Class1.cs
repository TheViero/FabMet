using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double GetArea()
            {
                return Math.PI * radius * radius;
            }
        }

        public class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public override double GetArea()
            {
                return length * width;
            }
        }

        public class Triangle : Shape
        {
            private double baseLength;
            private double height;

            public Triangle(double baseLength, double height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }

            public override double GetArea()
            {
                return 0.5 * baseLength * height;
            }
        }

        public abstract class ShapeFactory
        {
            public abstract Shape CreateShape();
        }

        public class CircleFactory : ShapeFactory
        {
            private double radius;

            public CircleFactory(double radius)
            {
                this.radius = radius;
            }

            public override Shape CreateShape()
            {
                return new Circle(radius);
            }
        }

        public class RectangleFactory : ShapeFactory
        {
            private double length;
            private double width;

            public RectangleFactory(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public override Shape CreateShape()
            {
                return new Rectangle(length, width);
            }
        }

        public class TriangleFactory : ShapeFactory
        {
            private double baseLength;
            private double height;

            public TriangleFactory(double baseLength, double height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }

            public override Shape CreateShape()
            {
                return new Triangle(baseLength, height);
            }
        }
    }
}

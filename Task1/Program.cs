using System;

namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }

            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("All sides must be greater than zero.");
            }

            // Проверка треугольного неравенства
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("Invalid triangle from given sides.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public bool IsRightAngled()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            // С помощью Array.Sort мы знаем, что под индексом 2 находится наибольшая сторона треугольника (гипотенуза)
            // Массив изменился, потому что он ссылочного типа. Мы не передаем копию, а ссылку на массив в Array.Sort
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }

    public class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}

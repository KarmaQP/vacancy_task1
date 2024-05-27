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

    // class Program
    // {
    //     static void Main()
    //     {
    //         Circle circle = new(3);
    //         double circleArea = ShapeCalculator.CalculateArea(circle);
    //         Console.WriteLine($"Circle area: {circleArea}");

    //         Triangle triangle = new(3, 4, 5);
    //         double triangleArea = ShapeCalculator.CalculateArea(triangle);
    //         Console.WriteLine($"Triangle area: {triangleArea}");

    //         bool isRightAngled = triangle.IsRightAngled();
    //         Console.WriteLine($"Is the triangle right-angled? {isRightAngled}");
    //     }
    // }
}

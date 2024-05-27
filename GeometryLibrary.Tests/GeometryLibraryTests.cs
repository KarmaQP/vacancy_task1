using System;

namespace GeometryLibrary.Tests
{
    public class GeometryLibraryTests
    {
        [Fact]
        public void Circle_CalculateArea_ReturnsCorrectValue()
        {
            double radius = 3;
            Circle circle = new(radius);
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double actualArea = circle.CalculateArea();

            // Точность до 5 знаков после запятой
            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnsCorrectValue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new(side1, side2, side3);

            // Полупериметр треугольника s = (a + b + c) / 2, где a, b, c - длины сторон треугольника
            double s = (side1 + side2 + side3) / 2;

            // Площадь находим с помощью формулы Герона
            double expectedArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            double actualArea = triangle.CalculateArea();

            // Точность до 5 знаков после запятой
            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsTrue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new(side1, side2, side3);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.True(isRightAngled);
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsFalse()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 6;
            Triangle triangle = new(side1, side2, side3);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.False(isRightAngled);
        }

        [Fact]
        public void ShapeCalculator_CalculateArea_Circle_ReturnsCorrectValue()
        {
            double radius = 3;
            Circle circle = new(radius);

            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double actualArea = ShapeCalculator.CalculateArea(circle);

            // Точность до 5 знаков после запятой
            Assert.Equal(expectedArea, actualArea, 5);
        }

        [Fact]
        public void ShapeCalculator_CalculateArea_Triangle_ReturnsCorrectValue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new(side1, side2, side3);

            // Полупериметр треугольника s = (a + b + c) / 2, где a, b, c - длины сторон треугольника
            double s = (side1 + side2 + side3) / 2;

            // Площадь находим с помощью формулы Герона
            double expectedArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            double actualArea = ShapeCalculator.CalculateArea(triangle);

            // Точность до 5 знаков после запятой
            Assert.Equal(expectedArea, actualArea, 5);
        }
    }
}

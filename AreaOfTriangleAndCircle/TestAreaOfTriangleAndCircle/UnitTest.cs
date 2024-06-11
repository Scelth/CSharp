namespace TestAreaOfTriangleAndCircle
{
    using Xunit;
    using AreaOfTriangleAndCircle;

    public class ShapeLibraryTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            var calculator = new ShapeAreaCalculator();
            double area = calculator.CalculateArea(circle);
            Assert.Equal(Math.PI * 25, area, 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var calculator = new ShapeAreaCalculator();
            double area = calculator.CalculateArea(triangle);
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void NonRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}
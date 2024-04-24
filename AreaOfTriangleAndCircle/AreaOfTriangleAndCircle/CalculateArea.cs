namespace AreaOfTriangleAndCircle
{
    public class Geometry
    {
        public double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Sides of a triangle cannot be negative.");
            }

            double s = (sideA + sideB + sideC) / 2;

            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
    }
}

#region Класс дробь
    Fraction f1 = new(1, 2);
    Fraction f2 = new(2, 3);

    Fraction f3 = f1 + f2;
    Fraction f4 = f1 - f2;
    Fraction f5 = f1 * f2;
    Fraction f6 = f1 / f2;

    Console.WriteLine("First fraction: " + f1);
    Console.WriteLine("Second fraction: " + f2 + "\n");
    Console.WriteLine("+: " + f3);
    Console.WriteLine("-: " + f4);
    Console.WriteLine("*: " + f5);
    Console.WriteLine("/: " + f6);

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            int denominator = f1.Denominator * f2.Denominator;
            return new(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numerator = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            int denominator = f1.Denominator * f2.Denominator;
            return new(numerator, denominator);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Numerator;
            int denominator = f1.Denominator * f2.Denominator;
            return new(numerator, denominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            return new(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
#endregion

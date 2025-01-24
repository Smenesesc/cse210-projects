using System;

class Program
{
    public class Fraction
    {
        private int top;
        private int bottom;

        public Fraction()
        {
            top = 1;
            bottom = 1;
        }

        public Fraction(int top)
        {
            this.top = top;
            bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            this.top = top;
            this.bottom = bottom;
        }

        public int GetTop()
        {
            return top;
        }

        public void SetTop(int value)
        {
            top = value;
        }

        public int GetBottom()
        {
            return bottom;
        }

        public void SetBottom(int value)
        {
            bottom = value;
        }

        public string GetFractionString()
        {
            return $"{top}/{bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)top / bottom;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        fraction1.SetTop(5);
        fraction1.SetBottom(2);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}

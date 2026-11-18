using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue().ToString(CultureInfo.InvariantCulture));

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue().ToString(CultureInfo.InvariantCulture));

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue().ToString(CultureInfo.InvariantCulture));

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue().ToString(CultureInfo.InvariantCulture));

        Fraction f5 = new Fraction(6, 7);
        f5.SetTop(2);
        f5.SetBottom(9);
        Console.WriteLine($"Top: {f5.GetTop()}");
        Console.WriteLine($"Bottom: {f5.GetBottom()}");
    }
}

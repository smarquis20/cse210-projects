using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFrac1 = new Fraction();
        Fraction newFrac2 = new Fraction(6);
        Fraction newFrac3 = new Fraction(6,7);

        Console.WriteLine(newFrac1);
        Console.WriteLine(newFrac2);
        Console.WriteLine(newFrac3);

        Fraction newFrac4 = new Fraction();
        newFrac4.SetTop(5);

        Console.WriteLine(newFrac4.GetTop());

        Console.WriteLine(newFrac3.GetFractionString());
        Console.WriteLine(newFrac3.GetDecimalValue());



    }
}
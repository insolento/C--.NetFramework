using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    public class Fraction
    {
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        public int Top { get; set; }
        public int Bottom { get; set; }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            Fraction fraction = new Fraction();
            fraction.Top = left.Top * right.Bottom + right.Top * left.Bottom;
            fraction.Bottom = left.Bottom * right.Bottom;
            return fraction;
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            Fraction fraction = new Fraction();
            fraction.Top = left.Top * right.Bottom - right.Top * left.Bottom;
            fraction.Bottom = left.Bottom * right.Bottom;
            return fraction;
        }

        public override string ToString()
        {
            return $"Top: {Top}, bottom: {Bottom}";
        }
    }
}

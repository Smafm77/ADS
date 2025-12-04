using System.ComponentModel;
using System.Dynamic;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public int numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }
    public int denominator
    {
        get { return denominator; }
        set
        {
            if (value > 0)
            {
                denominator = value;
            }
            else
            {
                throw new ArithmeticException();
            }
        }
    }
    public static int operator +(Fraction a, Fraction b)
    {
        return a + b;
    }
    public static int operator *(Fraction a, Fraction b)
    {
        return a * b;
    }
    public void ShortenFraction()
    {
        int g = GCD(_numerator, _denominator);
        _numerator /= g;
        _denominator /= g;
    }

    private int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public int this[int i]
    {
        get
        {
            if (i == 0) return _numerator;
            if (i == 1) return _denominator;
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (i == 0) _numerator = value;
            else if (i == 1)
            {
                _denominator = value;
            }
            else throw new IndexOutOfRangeException();
        }
    }

    public override string ToString()
    {
        string s = "numerator: " + this[0] + " denumerator: " + this[1];
        return s;
    }

}


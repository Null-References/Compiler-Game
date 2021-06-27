using System;
public class Number
{
    public float value;

    public Number(float value)
    {
        this.value = value;
    }
    public static Number operator +(Number a, Number b)
        => new Number(a.value + b.value);
    public static Number operator -(Number a, Number b)
        => new Number(a.value - b.value);
    public static Number operator *(Number a, Number b)
        => new Number(a.value * b.value);
    public static Number operator /(Number a, Number b)
        => new Number(a.value / b.value);
    public static bool operator <(Number a, Number b)
        => a.value < b.value;
    public static bool operator >(Number a, Number b)
        => a.value > b.value;
    public static bool operator <=(Number a, Number b)
        => a.value <= b.value;
    public static bool operator >=(Number a, Number b)
        => a.value >= b.value;
    public static bool operator ==(Number a, Number b)
        => a.value == b.value;
    public static bool operator !=(Number a, Number b)
        => a.value != b.value;
}


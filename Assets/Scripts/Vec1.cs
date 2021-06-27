public static class Tokens
{
    public const string vec1 = "V1";
    public const string vec2 = "V2";
    public const string vec3 = "V3";
}
public abstract class Vec
{
    public static Vec Get(string type)
    {
        switch (type)
        {
            case Tokens.vec1:
                return new Vec1(0);
            case Tokens.vec2:
                return new Vec2();
            case Tokens.vec3:
                return new Vec3();
            default:
                return null;
        }
    }
}
public class Vec3 : Vec
{
    public float x, y, z;
}
public class Vec2 : Vec
{
    public float x, y;
}
public class Vec1 : Vec
{
    public float value;

    public Vec1(float value)
    {
        this.value = value;
    }
    public static Vec1 operator +(Vec1 a, Vec1 b)
        => new Vec1(a.value + b.value);
    public static Vec1 operator -(Vec1 a, Vec1 b)
        => new Vec1(a.value - b.value);
    public static Vec1 operator *(Vec1 a, Vec1 b)
        => new Vec1(a.value * b.value);
    public static Vec1 operator /(Vec1 a, Vec1 b)
        => new Vec1(a.value / b.value);
    public static bool operator <(Vec1 a, Vec1 b)
        => a.value < b.value;
    public static bool operator >(Vec1 a, Vec1 b)
        => a.value > b.value;
    public static bool operator <=(Vec1 a, Vec1 b)
        => a.value <= b.value;
    public static bool operator >=(Vec1 a, Vec1 b)
        => a.value >= b.value;
    public static bool operator ==(Vec1 a, Vec1 b)
        => a.value == b.value;
    public static bool operator !=(Vec1 a, Vec1 b)
        => a.value != b.value;
}


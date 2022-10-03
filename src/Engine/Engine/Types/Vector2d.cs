namespace Engine.Types;

public class Vector2d : IEquatable<Vector2d>
{
    public float X { get; }
    public float Y { get; }

    public Vector2d(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float Magnitude => MathF.Sqrt(X * X + Y * Y);

    public bool Equals(Vector2d? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return X.Equals(other.X) && Y.Equals(other.Y);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Vector2d)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public static bool IsMoreThan(Vector2d? x, Vector2d? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(null, y)) return false;
        if (ReferenceEquals(null, x)) return true;
        var magnitudeComparison = x.Magnitude.CompareTo(y.Magnitude);
        return x.Magnitude > y.Magnitude;
    }
    
    public bool MoreThan(Vector2d? y)
    {
        if (ReferenceEquals(this, y)) return false;
        if (ReferenceEquals(null, y)) return false;
        return Magnitude > y.Magnitude;
    }
}
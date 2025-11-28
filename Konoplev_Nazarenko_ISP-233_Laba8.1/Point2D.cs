public struct Point2D
{
    public int X;
    public int Y;

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }
    public double DistanceTo(Point2D other)
    {
        int dx = X - other.X;
        int dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void PrintPoint()
    {
        Console.WriteLine($"Точка ({X}, {Y})");
    }
}
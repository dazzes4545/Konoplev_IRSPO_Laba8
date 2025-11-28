namespace DZ
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Rectangle  
    {
        public int Width;
        public int Height;
        public Point Position;

        public Rectangle(int x, int y, int width, int height)  
        {
            Position = new Point(x, y);
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public bool ContainsPoint(Point point)
        {
            return point.X >= Position.X &&
                   point.X <= Position.X + Width &&
                   point.Y >= Position.Y &&
                   point.Y <= Position.Y + Height;
        }
    }
}
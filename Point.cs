namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(int x, int y)
        {
            int dx = X-x;
            int dy = Y-y;
            int x2 = dx*dx;
            int y2 = dy*dy;
            return (double)(System.Math.Sqrt(x2+y2));
        }
    }
}
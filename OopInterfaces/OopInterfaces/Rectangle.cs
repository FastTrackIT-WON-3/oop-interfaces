namespace OopInterfaces
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, int width, int height)
            : base(topLeft,
                   new Point(topLeft.X + width, topLeft.Y), // topRight
                   new Point(topLeft.X + width, topLeft.Y + height), // bottomRight
                   new Point(topLeft.X, topLeft.Y + height) // bottomLeft
                   )
        {
            Width = width;
            Height = height;
        }

        public int Height { get; }

        public int Width { get; }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}

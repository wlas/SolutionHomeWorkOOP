namespace HomeWork
{
    public class Rectangle : Point
    {
        private double _width;

        private double _height;

        public Rectangle(Color color, Condition condition, int x, int y, double width, double height) : base(color, condition, x, y)
        {
            _width = width;
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }
    }
}

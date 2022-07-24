namespace HomeWork
{
    public class Circle : Point
    {        
        private double _Radius;

        public Circle(Color color, Condition condition, int x, int y, double radius) : base(color, condition, x, y)
        {
            _Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_Radius, 2);
        }
    }
}

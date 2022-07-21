namespace HomeWork
{
    public abstract class Figure : IFigure
    {        
        private Color _Color;
        
        private Condition _Condition;
        
        private int _x;
        
        private int _y;

        public Color Color => _Color;

        public Condition Condition => _Condition;

        public int X => _x;

        public int Y => _y;

        public Figure(Color color, Condition condition, int x, int y)
        {
            _Color = color;
            _Condition = condition;
            _x = x;
            _y = y;
        }

        public override string ToString() => $"{Color}, {Condition}, {X}, {Y}";

        public Figure MoveX(int point)
        {
            _x = _x + point;
            return this;
        }
        
        public Figure MoveY(int point)
        {
            _y = _y + point;
            return this;
        }

        public Figure ChangeColor(Color color)
        {
            _Color = color;
            return this;
        }
        
        public Condition GetCondition(Figure f) => f._Condition;

        public abstract double Area();

    }
}

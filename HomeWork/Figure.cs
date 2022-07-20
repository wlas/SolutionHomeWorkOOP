namespace HomeWork
{
    public class Figure
    {
        /// <summary>
        /// Цвет фигуры
        /// </summary>
        private Color _Color;

        /// <summary>
        /// Состояние фигуры
        /// </summary>
        private Condition _Condition;

        /// <summary>
        /// Передвижение фигуры по оси X
        /// </summary>
        private int _x;

        /// <summary>
        /// Передвижение фигуры по оси Y
        /// </summary>
        private int _y;

        public Color Color =>;

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

        /// <summary>
        ///  Метод возвращает состояние фигуры (видимое/невидимое)
        /// </summary>
        /// <param name="f">Экземпляр фигуры</param>
        /// <returns>Состояние фигуры</returns>
        public Condition GetCondition(Figure f) => f._Condition;
    }
}

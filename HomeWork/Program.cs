using HomeWork;

Console.WriteLine("\nFigure:");

Figure figure = new(Color.Red, Condition.Visible, 25, 5);
Console.WriteLine(figure);

Console.WriteLine("\nPoint:");

Point point = new(Color.Blue, Condition.Invisible, 35, 4);
Console.WriteLine(point);
point.MoveX(10);
Console.WriteLine("MoveX(10): " + point);
point.MoveY(-15);
Console.WriteLine("MoveY(-15): " + point);

Console.WriteLine("\nCircle:");

Circle circle = new(Color.Yellow, Condition.Visible, 10, 25, 12);
Console.WriteLine(circle);
circle.MoveX(12);
Console.WriteLine("MoveX(12): " + circle);
circle.MoveY(27);
Console.WriteLine("MoveY(27): " + circle);
Console.WriteLine("Radius(12): " + circle.Area());




Console.ReadLine();

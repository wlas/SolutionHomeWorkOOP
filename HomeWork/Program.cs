using HomeWork;

Console.WriteLine("\nFigure:");

Figure figure = new(Color.Red, Condition.Visible, 25, 5);
Console.WriteLine(figure);

Console.WriteLine("\nPoint:");

Point point = new(Color.Blue, Condition.Invisible, 35, 4);
Console.WriteLine(point);
point.MoveX(10);
Console.WriteLine("MoveX(10):" + point);
point.MoveY(-15);
Console.WriteLine("MoveY(-15):" + point);

Console.ReadLine();

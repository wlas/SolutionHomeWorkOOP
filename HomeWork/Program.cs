﻿using HomeWork;


Console.WriteLine("\nPoint:");

Point point = new(Color.Blue, Condition.Invisible, 35, 4);
Console.WriteLine(point);
point.ChangeColor(Color.Yellow);
point.MoveX(10);
Console.WriteLine("MoveX(10): " + point);
point.MoveY(-15);
Console.WriteLine("MoveY(-15): " + point);

Console.WriteLine("\nCircle:");

Circle circle = new(Color.Yellow, Condition.Visible, 10, 25, 12);
Console.WriteLine(circle);
circle.ChangeColor(Color.White);
circle.MoveX(12);
Console.WriteLine("MoveX(12): " + circle);
circle.MoveY(27);
Console.WriteLine("MoveY(27): " + circle);
Console.WriteLine("Radius(12): " + circle.Area());

Console.WriteLine("\nRectangle:");

Rectangle rectangle = new(Color.Red, Condition.Visible, 7, 14, 100, 50);
Console.WriteLine(rectangle);
rectangle.ChangeColor(Color.Yellow);
rectangle.MoveX(12);
Console.WriteLine("MoveX(12): " + rectangle);
rectangle.MoveY(3);
Console.WriteLine("MoveY(3): " + rectangle);
Console.WriteLine("Area(100,50): " + rectangle.Area());


Console.ReadLine();

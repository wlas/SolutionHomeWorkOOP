using HomeWork;

RationalNumbers numb1 = new();
RationalNumbers numb2 = new(100);
RationalNumbers numb3 = new(21, 51);

Console.WriteLine(numb1.ToString());
Console.WriteLine(numb2.ToString());
Console.WriteLine(numb3.ToString());

var sum = numb2 + numb3;
Console.WriteLine("Переопредение сложения: " + sum.ToString());

numb1++;
Console.WriteLine("Переопредение постфикс сложения: " + numb1.ToString());

sum--;
Console.WriteLine("Переопредение постфикс вычетния:" + sum.ToString());

var mult = sum * numb1;
Console.WriteLine("Переопредение умножения: " + mult.ToString());

var div = mult / numb1;
Console.WriteLine("Переопредение деления: " + div.ToString());

var perc = mult % numb1;
Console.WriteLine("Переопредение проценты: " + perc.ToString());

var minus = perc - sum;
Console.WriteLine("Переопредение вычетение: " + minus.ToString());

Console.ReadLine();
           

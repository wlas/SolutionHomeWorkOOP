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
Console.WriteLine("Переопредение вычетания: " + minus.ToString());


RationalNumbers n1 = new(10, 10);
RationalNumbers n2 = new(11, 10);
RationalNumbers n3 = new(1, 10);
RationalNumbers n4 = n1 + n3;
bool result = (n1 > n2);
Console.WriteLine("Переопредение знака больше: " + result);

result = (n1 < n2);
Console.WriteLine("Переопредение знака меньше: " + result);

result = (n4 == n2);
Console.WriteLine("Переопредение знака равно: " + result);

result = (n1 != n4);
Console.WriteLine("Переопредение знака не равно: " + result);

result = (n1 >= n3);
Console.WriteLine("Переопредение знака больше или равно: " + result);

result = (n4 <= n2);
Console.WriteLine("Переопредение знака меньше или равно: " + result);

Console.WriteLine("Переопредение сравнения: " + n4.Equals(n2));

int a = (int)n1;
float b = (float)n2;

var nn1 = (RationalNumbers)a;
b += (float)0.05613;
var nn2 = (RationalNumbers)b;

Console.ReadLine();
           

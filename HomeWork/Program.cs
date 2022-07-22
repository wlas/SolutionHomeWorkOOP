using HomeWork;


ACoder a = new();
string s = "Hello_World";
string j = a.Encode(s);
Console.WriteLine(j);
Console.WriteLine(a.Decode(j));

Console.WriteLine("++++++++++++++++++++++");

BCoder b = new();
string str = "Hello_World";
string e = b.Encode(str);
Console.WriteLine(e);
Console.WriteLine(b.Decode(e));
Console.ReadLine();

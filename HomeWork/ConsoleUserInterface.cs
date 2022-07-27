namespace HomeWork;
public class ConsoleUserInterface : IUserInterface
{
    public string ReadLine(string? Prompt)
    {
        if(Prompt is { Length: 0 })        
            WriteLine(Prompt);

        return Console.ReadLine()!;        
    }

    public void WriteLine(string str)
    {
        Console.WriteLine(str);
    }
}

namespace HomeWork;
public interface IUserInterface
{
    void Write(string str);
    void WriteLine(string str);
    string ReadLine(string? Prompt, bool PromntNewLine = true);
}


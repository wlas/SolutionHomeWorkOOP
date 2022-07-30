namespace HomeWork;
public interface IUserInterface
{
    void Write(string str);

    void WriteLine(string str);

    string ReadLine(string? Prompt, bool PromntNewLine = true);

    int ReadInt(string? Prompt, bool PromntNewLine = true);

    double ReadDouble(string? Prompt, bool PromntNewLine = true);
}


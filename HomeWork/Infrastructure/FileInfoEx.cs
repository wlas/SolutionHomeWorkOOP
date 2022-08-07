namespace HomeWork.Infrastructure;

public static class FileInfoEx
{
    public static IEnumerable<string> EnumLines(FileInfo file)
    {
        using var reader = file.OpenText();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            yield return line;
        }
    }
}

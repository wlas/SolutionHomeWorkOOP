using HomeWork.Commands.Base;
using HomeWork.Infrastructure;
using System.Text.RegularExpressions;

namespace HomeWork.Commands;

public class ReadFileTxtComand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Получает информацию о текстовом файле.";


    public ReadFileTxtComand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды получения информации о текстовом файле, необходимо указать один параметр - название файла с его расширением.");
            return;
        }

        var dir_path = args[1];

        FileInfo? file;

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);
        file = new FileInfo(dir_path);

        if (file.Exists)
        {
            if(file.Extension == ".txt")
            {
                int count_words = 0;
                int count_line = 0;
                int count_tab = 0;

                foreach (var line in FileInfoEx.EnumLines(file))
                {
                    count_words += Regex.Split(line, @"\b\w+\b").Count();
                    count_tab += Regex.Split(line, "[^\r\n]+((\r|\n|\r\n)[^\r\n]+)*").Count();                    
                    count_line++;
                }

                _UserInterface.WriteLine($"Общее количество слов в файле: {count_words}, Количество абзатцев: {count_tab} Количество строк: {count_line}");


            }
            else
            {
                _UserInterface.WriteLine($"Ошибка. Файл не имеет разрешние txt.");

            }
        }
        else
        {
            _UserInterface.WriteLine($"Ошибка. Файл не определен.");
        }
    }
}

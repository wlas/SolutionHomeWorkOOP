using HomeWork.Commands.Base;

namespace HomeWork.Commands;

public class CreateFileComand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Создание файла.";

    public CreateFileComand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды создания файла необходимо указать один параметр - название файла с его разрешением. Пример: NameFile.txt");
            return;
        }

        var file_path = args[1];

        FileInfo? file;

        if (!Path.IsPathRooted(file_path))
            file_path = Path.Combine(_FileManager.CurrentDirectory.FullName, file_path);
        file = new FileInfo(file_path);

        if (!file.Exists)
        {
            File.Create(file_path).Dispose();
            _UserInterface.WriteLine($"Файл {file.Name} успешно создан.");
        }
        else
        {
            _UserInterface.WriteLine($"Ошибка. Файл с таким же именем {file.Name}, уже существует в данной директории.");
        }

    }
}

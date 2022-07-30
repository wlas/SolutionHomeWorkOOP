using HomeWork.Commands.Base;

namespace HomeWork.Commands;

public class CreateDirectoryComand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Создание новой директории.";

    public CreateDirectoryComand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }
    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды создания каталога необходимо указать один параметр - целевой каталог");
            return;
        }

        var dir_path = args[1];

        DirectoryInfo? directory;

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);
        directory = new DirectoryInfo(dir_path);

        if (!directory.Exists)
        {
            Directory.CreateDirectory(dir_path);

            if (directory.Exists)
            {
                _UserInterface.WriteLine($"Директория {directory.Name} успешно создана.");
            }
        }       

    }
}

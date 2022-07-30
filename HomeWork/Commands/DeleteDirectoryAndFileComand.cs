using HomeWork.Commands.Base;

namespace HomeWork.Commands;

public class DeleteDirectoryAndFileComand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    private string _Parametr;
    public override string Description => "Удаление директории или файла.";

    public DeleteDirectoryAndFileComand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length < 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды удаления каталога или файла необходимо указать один параметр - целевой каталог или название файла с расширением. Параметр: /s - удаление всех файлов и подкаталогов.");
            return;
        }

        var dir_path = args[1];

        if(args.Length > 2)
        {
            _Parametr = args[2];
        }


        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);


        if (Directory.Exists(dir_path))
        { 
            var directory = new DirectoryInfo(dir_path);

            if (_UserInterface.ReadYesNo($"Вы точно хотите удалить данную директорию? y/n: ", false))
            {
                var all = false;

                if (_Parametr == "/s")
                {
                    all = true;
                }

                Directory.Delete(dir_path, all);

                _UserInterface.WriteLine($"Директория \"{directory.Name}\" успешно удалена.");

            }
        }
        else if (File.Exists(dir_path))
        {
            var file = new FileInfo(dir_path);

            if (_UserInterface.ReadYesNo($"Вы точно хотите удалить данный файл? y/n: ", false))
            {
                File.Delete(dir_path);

                _UserInterface.WriteLine($"Файл \"{file.Name}\" успешно удален.");
            }
        }
        else
        {
            _UserInterface.WriteLine($"Ошибка. Имя директории или файла не определено.");
        }
    }
}

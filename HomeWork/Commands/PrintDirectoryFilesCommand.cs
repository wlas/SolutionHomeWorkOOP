using HomeWork.Commands.Base;

namespace HomeWork.Commands;

public class PrintDirectoryFilesCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Вывод содержимого директории";

    public PrintDirectoryFilesCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var directory = _FileManager.CurrentDirectory;
        _UserInterface.WriteLine($"Содержимое директории {directory}:");
        string strTitle = String.Format("{0,-45}{1,-10}{2,1}", "Имя","Размер","Дата");
        _UserInterface.WriteLine(strTitle);
        _UserInterface.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


        var dirs_count = 0;
        foreach (var sub_dir in directory.EnumerateDirectories())
        {
            string str = String.Format("{0,-45}{1,-10}{2,1}", sub_dir.Name, "<Папка>", sub_dir.CreationTime);

            _UserInterface.WriteLine(str);
            dirs_count++;
        }

        var files_count = 0;
        long total_length = 0;
        foreach (var file in directory.EnumerateFiles())
        {
            string str = String.Format("{0,-40}{1,12}{2,22}", file.Name, file.Length, file.CreationTime);

            _UserInterface.WriteLine(str);
            files_count++;
            total_length += file.Length;
        }

        _UserInterface.WriteLine("");
        _UserInterface.WriteLine($"Директорий {dirs_count}, файлов {files_count} (суммарный размер {total_length} байт)");
    }
}

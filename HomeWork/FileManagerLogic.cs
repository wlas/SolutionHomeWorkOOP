﻿using HomeWork.Commands;
using HomeWork.Commands.Base;

namespace HomeWork;

public class FileManagerLogic
{
    private bool _CanWork = true;

    private readonly IUserInterface _UserInterface;

    public DirectoryInfo CurrentDirectory { get; set; } = new("c:\\");

    public IReadOnlyDictionary<string, FileManagerCommand> Commands { get; }

    public FileManagerLogic(IUserInterface UserInterface)
    {
        _UserInterface = UserInterface;

        var list_dir_command = new PrintDirectoryFilesCommand(UserInterface, this);
        var help_command = new HelpCommand(UserInterface, this);
        var quit_command = new QuitCommand(this);
        Commands = new Dictionary<string, FileManagerCommand>
        {
            { "drives", new ListDrivesCommand(UserInterface) },
            { "dir", list_dir_command },
            { "ListDir", list_dir_command },
            { "help", help_command },
            { "?", help_command },
            { "q", quit_command },
            { "exit", quit_command },
            { "cd", new ChangeDirectoryCommand(UserInterface, this) },
            { "mkdir", new CreateDirectoryComand(UserInterface, this) },
            { "cr", new CreateFileComand(UserInterface, this) },
            { "rm", new DeleteDirectoryAndFileComand(UserInterface, this) },
        };
    }

    public void Start()
    {
        _UserInterface.WriteLine("Файловый менеджер v2.0");

        do
        {
            var input = _UserInterface.ReadLine("> ", false);

            var args = input.Split(' ');
            var command_name = args[0];

            if (!Commands.TryGetValue(command_name, out var command))
            {
                _UserInterface.WriteLine($"Неизвестная команда {command_name}.");
                _UserInterface.WriteLine("Для справки введите help, для выхода quit");
                continue;
            }

            try
            {
                command.Execute(args/*[1..]*/);
            }
            catch (Exception error)
            {
                _UserInterface.WriteLine($"При выполнении команды {command_name} произошла ошибка:");
                _UserInterface.WriteLine(error.Message);
            }
        }
        while (_CanWork);


        _UserInterface.WriteLine("Логика файлового менеджера завершена. Всего наилучшего!");
    }

    public void Stop()
    {
        _CanWork = false;
    }
}


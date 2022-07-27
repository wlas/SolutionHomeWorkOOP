namespace HomeWork;

public class FileManagerLogic
{
    private readonly IUserInterface _userInterface;

    public FileManagerLogic(IUserInterface UserInterface)
    {
        _userInterface = UserInterface;
    }

    public void Start()
    {
        _userInterface.WriteLine("Файловый менаджер v2.0");

        var can_work = true;

        do 
        {
            var input = _userInterface.ReadLine("Введите команду:");
            if (input == "quit")
                can_work = false;
            else
                _userInterface.WriteLine($"Введена команда: {input}");
        } 
        while (can_work);
    }
}


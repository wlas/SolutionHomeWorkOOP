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
    }
}

